using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QueryConstructor
{
    public partial class ConstructorForm : Form
    {
        private const string ConnStrName = "DataBaseCStr";
        private const string ConnStrSection = "connectionStrings";
        private BindingList<ColumnInfo> _columns;
        private Dictionary<string, List<FKInfo>> foreignKeys;
        private Dictionary<string, List<FKInfo>> primaryKeys;
        private string query = "";
        private bool queryChanged = false;

        public ConstructorForm()
        {
            InitializeComponent();
            InitializeDynamicComponents();
            InitializeLists();
            BindDataSources();
        }

        private void InitializeDynamicComponents()
        {
            _boolVal = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    DataSource = new List<bool> { false, true },
                    Dock = DockStyle.Fill
                };
            _dateVal = new DateTimePicker{ Dock = DockStyle.Fill, Format = DateTimePickerFormat.Custom };
            _valTextBox = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
        }

        private void InitializeLists()
        {
            foreignKeys = new Dictionary<string, List<FKInfo>>();
            primaryKeys = new Dictionary<string, List<FKInfo>>();
            _requiredTables = new BindingList<string>();
            _columns = new BindingList<ColumnInfo> { RaiseListChangedEvents = true };
            _columns.ListChanged += ResetListBindings;
            _notSelectedColumns = new BindingList<ColumnInfo> { RaiseListChangedEvents = true };
            _notSelectedColumns.ListChanged += UpdateRestUi;
            _selectedColumns = new BindingList<ColumnInfo> { RaiseListChangedEvents = true };
            _selectedColumns.ListChanged += UpdateSelectionUi;
            _conditions = new BindingList<Condition> { RaiseListChangedEvents = true };
            _joinConditions = new List<JoinCondition>();
            _notOrderedColumns = new BindingList<ColumnInfo> { RaiseListChangedEvents = true };
            _notOrderedColumns.ListChanged += UpdateNotOrderedUi;
            _orderedColumns = new BindingList<ColumnInfo>{ RaiseListChangedEvents = true };
            _orderedColumns.ListChanged += UpdateOrderedUi;
        }

        private void BindDataSources()
        {
            restOfColumnsListBox.DataSource = _notSelectedColumns;
            selectedColumnsListBox.DataSource = _selectedColumns;
            conditionBindingSource.DataSource = _conditions;
            columnInfoBindingSource.DataSource = _columns;
            logicOperationBindingSource.DataSource = _operationsForFirstElements;
            notOrderedColsListBox.DataSource = _notOrderedColumns;
            orderedColumnsListBox.DataSource = _orderedColumns;
        }

        private void ResetListBindings(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    {
                        _notSelectedColumns.Add(_columns[e.NewIndex]);
                        break;
                    }
            }
        }

        private void ResetListBindings()
        {
            _selectedColumns.ResetBindings();
            _notSelectedColumns.ResetBindings();
            _orderedColumns.ResetBindings();
            _notOrderedColumns.ResetBindings();
        }

        private void ConstructorForm_Load(object sender, EventArgs e)
        {
            UpdateDbInfo();
        }

        private void ChangeSqlAccess(bool enable)
        {
            viewQueryButton.Enabled = enable;
            executeQueryButton.Enabled = enable;
        }

        private string FormQuery(bool withValues)
        {
            var selectPart = $"SELECT {string.Join(", ", _selectedColumns.Select(col => col.ToLongString()))}\n";
            var fromPart = $"FROM {string.Join(",", _requiredTables.Select(table => $"[{table}]"))}\n";
            var wherePart = "";
            if (_conditions.Count > 0 || _joinConditions.Count > 0)
            {
                wherePart = $"{string.Join(" ", _conditions.Select(condition => condition.ToString(withValues)))}";
                wherePart = $"WHERE {(_joinConditions.Count == 0 ? wherePart + '\n' : _conditions.Count == 0 ? $" {string.Join(" AND ", _joinConditions.Select(cond => cond.ToString()))}\n" : $"{(_conditions.Any(cond => cond.LogicOp.RealName == "OR") ? $"({wherePart})" : wherePart)} AND {string.Join(" AND ", _joinConditions.Select(cond => cond.ToString()))}\n")}";
            }
            var orderByPart = _orderedColumns.Count > 0 ?
                $"ORDER BY {string.Join(",", _orderedColumns.Select(col => col.OrderedColumnToString()))}" :
                "";
            queryChanged = false;
            query = $"{selectPart}{fromPart}{wherePart}{orderByPart}";
            return query;
        }

        private void ViewQueryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormQuery(true));
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager
                    .ConnectionStrings[ConnStrName]
                    .ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(FormQuery(false), connection);
                foreach (var cond in _conditions)
                    command.Parameters.AddWithValue(cond.Variable, cond.Value);
                
                pagesControl.SelectedIndex = 3;
                using (var reader = command.ExecuteReader())
                {
                    var data = new DataTable();
                    data.Load(reader);
                    resultDGV.DataSource = data;
                }
                for (int i = 0; i < _selectedColumns.Count; i++)
                    resultDGV.Columns[i].HeaderText = _selectedColumns[i].VisibleName;
            }
        }

        private void ClearLists()
        {
            _selectedColumns.Clear();
            _notSelectedColumns.Clear();
            _conditions.Clear();
            _orderedColumns.Clear();
            _notOrderedColumns.Clear();
            resultDGV.DataSource = null;
            ResetListBindings();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            pagesControl.SelectedIndex = 0;
            foreach (var column in _columns)
                _notSelectedColumns.Add(column);
            ChangeSqlAccess(false);
        }

        private void CustomizeConnButton_Click(object sender, EventArgs e)
        {
            var connInfo = 
                ConfigurationManager
                    .ConnectionStrings[ConnStrName]
                    .ConnectionString.Split(';')
                    .Where(connPart => connPart != "")
                    .Select(pair =>
                            {
                                var newPair = pair.Split('=');
                                return newPair[1];
                            })
                    .ToList();
            using (var connD = new ConnectionDialog(connInfo[0], connInfo[1].Replace("\"", "")))
            {
                if (connD.ShowDialog(this) != DialogResult.OK) return;
                CustomizeConnectionString(connD.ConnBuilder.ConnectionString);
                _columns.Clear();
                ClearLists();
                UpdateDbInfo();
            }
        }

        private void ColsInfoButton_Click(object sender, EventArgs e)
        {
            new ColumnsInfoForm(_columns).ShowDialog();
            _columns.ResetBindings();
            _conditions.Clear();
            logOpComboBox.DataSource = _operationsForFirstElements;
            ResetListBindings();
        }

        private static void CustomizeConnectionString(string newConnStr)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ((ConnectionStringsSection)config.GetSection(ConnStrSection)).ConnectionStrings[ConnStrName].ConnectionString = newConnStr;
            config.Save();
            ConfigurationManager.RefreshSection(ConnStrSection);
        }

        private void UpdateDbInfo()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnStrName].ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show(Localization.DBConnectionFailure, Localization.ServerConnectionFailureCaption);
                    return;
                }
                var tempCols = new List<ColumnInfo>();
                using (var reader = new SqlCommand(_getColumnsQuery, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var currentColumn = new ColumnInfo(reader[TableColumn] as string, reader[ColColumn] as string, reader[ColTypeColumn] as string, reader[MaxLength] as int?);
                        tempCols.Add(currentColumn);
                    }
                }
                using (var reader = new SqlCommand(_getRealColumnsQuery, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var currentColumn = new ColumnInfo(reader[FieldsTableCol] as string, reader[FieldsColumnCol] as string, reader[FieldsVisibleCol] as string);
                        var tempCol = tempCols.Find(col => col.RealName == currentColumn.RealName && col.TableName == currentColumn.TableName);
                        tempCol.VisibleName = currentColumn.VisibleName;
                        _columns.Add(tempCol);
                    }
                }
                using (var reader = new SqlCommand(_getLinksQuery, connection).ExecuteReader())
                {
                    primaryKeys.Clear();
                    foreignKeys.Clear();
                    while (reader.Read())
                    {
                        var curFKTable = reader[FkTableName] as string;
                        var temp = new FKInfo(reader[FkColName] as string, curFKTable, reader[PkColName] as string, reader[PkTableName] as string);
                        if (!foreignKeys.ContainsKey(curFKTable))
                            foreignKeys.Add(curFKTable, new List<FKInfo>());
                        if (!primaryKeys.ContainsKey(temp.PKeyTable))
                            primaryKeys.Add(temp.PKeyTable, new List<FKInfo>());
                        foreignKeys[curFKTable].Add(temp);
                        primaryKeys[temp.PKeyTable].Add(temp);
                    }
                }
            }
        }

        private void ClearRedundantLinks(string tableName)
        {
            var childLinks = _joinConditions.Where(cond => cond.Info.PKeyTable == tableName).ToList();
            foreach (var link in childLinks)
                ClearDownJoinChain(link);
            var parentLinks = _joinConditions.Where(cond => cond.Info.FTable == tableName).ToList();
            foreach (var link in parentLinks)
                ClearUpperJoinChain(link);
        }

        private void ClearUpperJoinChain(JoinCondition cond)
        {
            var childLinks = _joinConditions.Where(cnd => cond.Info.PKeyTable == cond.Info.FTable).ToList();
            foreach (var link in childLinks)
                ClearDownJoinChain(link);
            var parentLinks = _joinConditions.Where(condition => condition.Info.FTable == cond.Info.PKeyTable).ToList();
            if (_selectedColumns.Any(column => column.TableName == cond.Info.FTable) || _conditions.Any(col => col.Column.TableName == cond.Info.FTable))
                return;
            foreach (var link in parentLinks)
                ClearUpperJoinChain(link);
            _requiredTables.Remove(cond.Info.FTable);
            _joinConditions.Remove(cond);
        }

        private void ClearDownJoinChain(JoinCondition cond)
        {
            var childLinks = _joinConditions.Where(condition => condition.Info.PKeyTable == cond.Info.FTable).ToList();
            if (_selectedColumns.Any(column => column.TableName == cond.Info.PKeyTable) || _conditions.Any(col => col.Column.TableName == cond.Info.FTable))
                return;
            foreach (var link in childLinks)
                ClearDownJoinChain(link);
            var parentLinks = _joinConditions.Where(cnd => cond.Info.FTable == cond.Info.PKeyTable).ToList();
            foreach (var link in parentLinks)
                ClearUpperJoinChain(link);
            _requiredTables.Remove(cond.Info.PKeyTable);
            _joinConditions.Remove(cond);
        }

        private void TryClearConds(string deltable)
        {
            if (!_selectedColumns.Any(column => column.TableName.Equals(deltable)))
            {
                if (!_conditions.Any(col => col.Column.TableName == deltable))
                    _requiredTables.Remove(deltable);
                ClearRedundantLinks(deltable);
                var temp = _conditions.ToList();
                _conditions.Clear();
                foreach (var cond in temp)
                {
                    if (_requiredTables.Contains(cond.Column.TableName))
                        _conditions.Add(cond);
                }
                _conditions.ResetBindings();

            }
        }

        private void TryJoin(string newTable)
        {
            var prevReqTables = _requiredTables.ToList();
            foreach (var table in prevReqTables)
            {
                if (table == newTable)
                    continue;
                var path = TryFindPath(newTable, table, new List<string>());
                var pathFoundNow = path != null;
                if (!pathFoundNow) continue;
                foreach (var cond in path)
                {
                    var newCond = new JoinCondition(cond);
                    if (!_joinConditions.Any(cnd => cnd.Equals(newCond)))
                        _joinConditions.Add(newCond);
                    if (!_requiredTables.Contains(cond.FTable))
                        _requiredTables.Add(cond.FTable);
                    if (!_requiredTables.Contains(cond.PKeyTable))
                        _requiredTables.Add(cond.PKeyTable);
                }
            }
            prevReqTables = _requiredTables.ToList();
            foreach (var table in prevReqTables)
            {
                if (table == newTable)
                    continue;
                var path = TryFindPath(table, newTable, new List<string>());
                var pathFoundNow = path != null;
                if (!pathFoundNow) continue;
                foreach (var cond in path)
                {
                    var newCond = new JoinCondition(cond);
                    if (!_joinConditions.Any(cnd => cnd.Equals(newCond)))
                        _joinConditions.Add(newCond);
                    if (!_requiredTables.Contains(cond.FTable))
                        _requiredTables.Add(cond.FTable);
                    if (!_requiredTables.Contains(cond.PKeyTable))
                        _requiredTables.Add(cond.PKeyTable);
                }
            }
        }

        private List<FKInfo> TryFindPath(string source, string destination, List<string> usedTables)
        {
            if (foreignKeys.ContainsKey(source))
            {
                if (foreignKeys.Any(pair => pair.Key == source && pair.Value.Any(fk => fk.PKeyTable == destination)))
                {
                    return foreignKeys[source].Where(fkInfo => fkInfo.PKeyTable == destination).ToList();
                }
                List<FKInfo> path = null;
                usedTables.Add(source);
                foreach (var connectedTable in foreignKeys[source])
                {
                    if (usedTables.Contains(connectedTable.PKeyTable))
                        continue;
                    path = TryFindPath(connectedTable.PKeyTable, destination, usedTables);
                    if (path == null)
                        continue;
                    path.Add(connectedTable);
                    break;
                }
                usedTables.Remove(source);
                return path;
            }
            if (primaryKeys.ContainsKey(source))
            {
                if (primaryKeys.Any(pair => pair.Key == source && pair.Value.Any(fk => fk.FTable == destination)))
                {
                    return primaryKeys[source].Where(fkInfo => fkInfo.FTable == destination).ToList();
                }
                List<FKInfo> path = null;
                usedTables.Add(source);
                foreach (var connectedTable in primaryKeys[source])
                {
                    if (usedTables.Contains(connectedTable.FTable))
                        continue;
                    path = TryFindPath(connectedTable.FTable, destination, usedTables);
                    if (path == null)
                        continue;
                    path.Add(connectedTable);
                    break;
                }
                usedTables.Remove(source);
                return path;
            }
            return null;
        }
    }
}