using System;
using System.ComponentModel;
using System.Linq;

namespace QueryConstructor
{
    public partial class ConstructorForm
    {
        private BindingList<ColumnInfo> _notSelectedColumns;
        private BindingList<ColumnInfo> _selectedColumns;

        private BindingList<string> _requiredTables;

        private void SelectFieldButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            var movedItem = restOfColumnsListBox.SelectedItem as ColumnInfo;
            _notSelectedColumns.Remove(movedItem);
            _selectedColumns.Add(movedItem);
        }

        private void PickOutFieldButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            var movedItem = selectedColumnsListBox.SelectedItem as ColumnInfo;
            _selectedColumns.Remove(movedItem);
            _notSelectedColumns.Add(movedItem);
        }

        private void SelectAllFieldsButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            while (_notSelectedColumns.Count > 0)
            {
                var movedItem = _notSelectedColumns.First();
                _notSelectedColumns.Remove(movedItem);
                _selectedColumns.Add(movedItem);
            }
        }

        private void PickOutSelectionButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            while (_selectedColumns.Count > 0)
            {
                var movedItem = _selectedColumns.First();
                _selectedColumns.Remove(movedItem);
                _notSelectedColumns.Add(movedItem);
            }
        }

        private void UpdateRestUi(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    {
                        break;
                    }
                case ListChangedType.ItemAdded:
                    {
                        _notOrderedColumns.Remove(_notSelectedColumns[e.NewIndex]);
                        _orderedColumns.Remove(_notSelectedColumns[e.NewIndex]);
                        _notSelectedColumns[e.NewIndex].Order = ColumnInfo.Ordering.None;
                        selectFieldButton.Enabled = true;
                        var prevTables = _requiredTables.ToList();
                        foreach (var table in prevTables)
                            TryClearConds(table);
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        selectFieldButton.Enabled = _notSelectedColumns.Count > 0;
                        break;
                    }
            }
            selectAllFieldsButton.Enabled = selectFieldButton.Enabled;
        }

        private void UpdateSelectionUi(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    {
                        if (_selectedColumns.Count > 0)
                            return;
                        ChangeSqlAccess(false);
                        _conditions.Clear();
                        _joinConditions.Clear();
                        _requiredTables.Clear();
                        pickOutFieldButton.Enabled = false;
                        break;
                    }
                case ListChangedType.ItemAdded:
                    {
                        ChangeSqlAccess(true);
                        pickOutFieldButton.Enabled = true;
                        _notOrderedColumns.Add(_selectedColumns[e.NewIndex]);
                        if (!_requiredTables.Contains(_selectedColumns[e.NewIndex].TableName))
                            _requiredTables.Add(_selectedColumns[e.NewIndex].TableName);
                        TryJoin(_selectedColumns[e.NewIndex].TableName);
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        var enable = _selectedColumns.Count > 0;
                        ChangeSqlAccess(enable);
                        pickOutFieldButton.Enabled = enable;
                        break;
                    }
            }
            pickOutSelectionButton.Enabled = pickOutFieldButton.Enabled;
        }
    }
}