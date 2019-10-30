using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QueryConstructor
{
    public partial class ConstructorForm
    {
        private ComboBox _boolVal;
        private DateTimePicker _dateVal;
        private ComboBox _valTextBox;

        private readonly double _minSqlFloat = double.Parse("-1,79E+308");
        private readonly double _maxSqlDecimal = double.Parse("1,0E+38") - 1;
        private readonly double _minSqlDecimal = double.Parse("-1,0E+38") + 1;
        private const double MaxMoney = 922337203685477.5807;
        private const double MinMoney = -922337203685477.5808;
        private const double MaxSmallMoney = 214748.3647;
        private const double MinSmallMoney = -214748.3648;

        private BindingList<Condition> _conditions;
        private List<JoinCondition> _joinConditions;

        private readonly List<LogicOperation> _operationsForFirstElements = new List<LogicOperation>
        {
            new LogicOperation("", ""),
            new LogicOperation("NOT", "НЕ")
        };

        private readonly List<LogicOperation> _operationsForOtherElements = new List<LogicOperation>
        {
            new LogicOperation("AND", "И"),
            new LogicOperation("OR", "ИЛИ"),
            new LogicOperation("AND NOT", "И НЕ"),
            new LogicOperation("OR NOT", "ИЛИ НЕ")
        };

        private void colComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var column = colComboBox.SelectedItem as ColumnInfo;
            if (column == null)
                return;
            ClearPrevHandler();
            critComboBox.DataSource = column.ValType.Description.Operations;
            SetNewHandler(column.ValType.Description.Class, column.ValType.Name, column);
        }

        private void ClearPrevHandler()
        {
            var prevControl = critPropsPanel.Controls[critPropsPanel.Controls.Count - 1];
            critPropsPanel.Controls.RemoveAt(critPropsPanel.Controls.Count - 1);
            _valTextBox.TextChanged -= FloatTextBoxChanged;
            _valTextBox.TextChanged -= IntTextBoxChanged;
            _valTextBox.TextChanged -= TextTextBoxValChanged;
            if (prevControl is ComboBox)
                (prevControl as ComboBox).SelectedIndex = -1;
        }

        private void SetNewHandler(ColumnInfo.ColumnTypeInfo.TypeClasses newColClass, string colType, ColumnInfo col)
        {
            Control newControl = null;
            if (newColClass == ColumnInfo.ColumnTypeInfo.TypeClasses.Floating || newColClass == ColumnInfo.ColumnTypeInfo.TypeClasses.Integer || newColClass == ColumnInfo.ColumnTypeInfo.TypeClasses.Text)
            {
                var values = new List<string>();
                _valTextBox.Items.Clear();
                using (var connection = new SqlConnection(ConfigurationManager
                    .ConnectionStrings[ConnStrName]
                    .ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand($"SELECT [{col.RealName}] FROM [{col.TableName}]", connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _valTextBox.Items.Add(reader[col.RealName].ToString());
                        }   
                    }
                }
            }
            switch (newColClass)
            {
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Boolean:
                    {
                        newControl = _boolVal;
                        addCondButton.Enabled = true;
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.DateTime:
                    {
                        newControl = _dateVal;
                        SetDateTimeFormat(colType);
                        addCondButton.Enabled = true;
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Floating:
                    {
                        newControl = _valTextBox;
                        _valTextBox.TextChanged += FloatTextBoxChanged;
                        addCondButton.Enabled = false;
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Integer:
                    {
                        newControl = _valTextBox;
                        _valTextBox.TextChanged += IntTextBoxChanged;
                        addCondButton.Enabled = false;
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Text:
                    {
                        newControl = _valTextBox;
                        _valTextBox.TextChanged += TextTextBoxValChanged;
                        addCondButton.Enabled = false;
                        break;
                    }
            }
            critPropsPanel.Controls.Add(newControl, 5, 1);
        }

        private void SetDateTimeFormat(string colType)
        {
            switch (colType)
            {
                case "date":
                    {
                        _dateVal.CustomFormat = Localization.DateFormat;
                        break;
                    }
                case "datetime":
                    {
                        _dateVal.CustomFormat = Localization.DateTimeFormat;
                        break;
                    }
                case "datetime2":
                    {
                        _dateVal.CustomFormat = Localization.DateTimeFormat;
                        break;
                    }
                case "datetimeoffset":
                    {
                        _dateVal.CustomFormat = Localization.DateTimeFormat;
                        break;
                    }
                case "smalldatetime":
                    {
                        _dateVal.CustomFormat = Localization.DateTimeFormat;
                        break;
                    }
                case "time":
                    {
                        _dateVal.CustomFormat = Localization.TimeFormat;
                        break;
                    }
            }
        }

        private void addCritButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            var column = colComboBox.SelectedItem as ColumnInfo;
            if (column == null)
            {
                MessageBox.Show(Localization.ColumnIsMissingMessage);
                addCondButton.Enabled = false;
                return;
            }
            _conditions.Add(new Condition(column, 
                                            critComboBox.SelectedItem as string, 
                                            SelectValue(column.ValType.Description.Class, column.ValType.Name),
                                            $"@var{_conditions.Count+1}",
                                            logOpComboBox.SelectedItem as LogicOperation));
            if (!_requiredTables.Contains(column.TableName))
            {
                _requiredTables.Add(column.TableName);
                TryJoin(column.TableName);
            }
                
            if (_conditions.Count == 1)
                logOpComboBox.DataSource = _operationsForOtherElements;
        }
        private object SelectValue(ColumnInfo.ColumnTypeInfo.TypeClasses colClass, string colType)
        {
            object val = null;
            switch (colClass)
            {
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Boolean:
                    {
                        val = _boolVal.SelectedItem as string == "True";
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.DateTime:
                    {
                        val = FormatDateTimeVal(colType);
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Floating:
                    {
                        val = double.Parse(_valTextBox.Text);
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Integer:
                    {
                        val = long.Parse(_valTextBox.Text);
                        break;
                    }
                case ColumnInfo.ColumnTypeInfo.TypeClasses.Text:
                    {
                        val = _valTextBox.Text;
                        break;
                    }
            }
            return val;
        }

        private DateTime FormatDateTimeVal(string colType)
        {
            var result = _dateVal.Value;
            switch (colType)
            {
                case "date":
                    {
                        result = result.Date;
                        break;
                    }
                case "time":
                    {
                        result = DateTime.Parse(result.ToLongTimeString());
                        break;
                    }
            }
            return result;
        }

        private void condsDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            queryChanged = true;
            var condTable = _conditions[e.Row.Index].Column.TableName;
            for (var i = e.Row.Index + 1; i < _conditions.Count; i++)
                _conditions[i].Variable = $"@var{i}";
            _conditions.RemoveAt(e.Row.Index);
            if (_conditions.Count == 0)
                logOpComboBox.DataSource = _operationsForFirstElements;
            var prevTables = _requiredTables.ToList();
            foreach (var table in prevTables)
                TryClearConds(table);
            e.Cancel = true;
        }

        private void colComboBox_BindingContextChanged(object sender, EventArgs e)
        {
            var column = colComboBox.SelectedItem as ColumnInfo;
            if (column == null)
                return;
            critComboBox.DataSource = column.ValType.Description.Operations;
            SetNewHandler(column.ValType.Description.Class, column.ValType.Name, column);
        }

        private void critComboBox_DataSourceChanged(object sender, EventArgs e)
        {
            queryChanged = true;
            critComboBox.SelectedIndex = -1;
        }

        private void IntTextBoxChanged(object sender, EventArgs e)
        {
            if (_valTextBox.Text.Trim() == "")
            {
                addCondButton.Enabled = false;
                return;
            }
            long val;
            if (!long.TryParse(_valTextBox.Text, out val))
            {
                MessageBox.Show(Localization.NaNMessage);
                addCondButton.Enabled = false;
                return;
            }
            bool overflow = false;
            var colType = (colComboBox.SelectedItem as ColumnInfo).ValType.Name;
            switch (colType)
            {
                case "int":
                    {
                        overflow = val < int.MinValue || val > int.MaxValue;
                        break;
                    }
                case "smallint":
                    {
                        overflow = val < short.MinValue || val > short.MaxValue;
                        break;
                    }
                case "tinyint":
                    {
                        overflow = val < byte.MinValue || val > byte.MaxValue;
                        break;
                    }
            }
            if (overflow)
            {
                MessageBox.Show(string.Format(Localization.OverflowMessage, colType));
                addCondButton.Enabled = false;
            }
            else addCondButton.Enabled = true;
        }

        private void FloatTextBoxChanged(object sender, EventArgs e)
        {
            if (_valTextBox.Text.Trim() == "")
            {
                addCondButton.Enabled = false;
                return;
            }
            double val;
            if (!double.TryParse(_valTextBox.Text, out val))
            {
                MessageBox.Show(Localization.NaNMessage);
                addCondButton.Enabled = false;
                return;
            }
            var overflow = false;
            var colType = (colComboBox.SelectedItem as ColumnInfo).ValType.Name;
            switch (colType)
            {
                case "float":
                    {
                        overflow = val < _minSqlFloat;
                        break;
                    }
                case "real":
                    {
                        overflow = val < float.MinValue || val > float.MaxValue;
                        break;
                    }
                case "decimal":
                    {
                        overflow = val < _minSqlDecimal || val > _maxSqlDecimal;
                        break;
                    }
                case "money":
                    {
                        overflow = val < MinMoney || val > MaxMoney;
                        break;
                    }
                case "smallmoney":
                    {
                        overflow = val < MinSmallMoney || val > MaxSmallMoney;
                        break;
                    }
                case "numeric":
                    {
                        overflow = val < MinSmallMoney || val > MaxSmallMoney;
                        break;
                    }
            }

            if (overflow)
            {
                MessageBox.Show(string.Format(Localization.OverflowMessage, colType));
                addCondButton.Enabled = false;
            }
            else addCondButton.Enabled = true;
        }

        private void TextTextBoxValChanged(object sender, EventArgs e)
        {
            addCondButton.Enabled = _valTextBox.Text.Trim() != "";
        }
    }
}