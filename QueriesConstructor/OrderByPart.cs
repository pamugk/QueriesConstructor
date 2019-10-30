using System;
using System.ComponentModel;
using System.Linq;

namespace QueryConstructor
{
    public partial class ConstructorForm
    {
        private BindingList<ColumnInfo> _notOrderedColumns;
        private BindingList<ColumnInfo> _orderedColumns;

        private void addOrderedColumnButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            var movedItem = notOrderedColsListBox.SelectedItem as ColumnInfo;
            movedItem.Order = ColumnInfo.Ordering.Ascending;
            _notOrderedColumns.Remove(movedItem);
            _orderedColumns.Add(movedItem);
        }

        private void PickOutOrderedColumnButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            var movedItem = orderedColumnsListBox.SelectedItem as ColumnInfo;
            movedItem.Order = ColumnInfo.Ordering.None;
            _orderedColumns.Remove(movedItem);
            _notOrderedColumns.Add(movedItem);
        }

        private void SelectAllColsButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            while (_notOrderedColumns.Count > 0)
            {
                var movedItem = _notOrderedColumns.First();
                movedItem.Order = ColumnInfo.Ordering.Ascending;
                _notOrderedColumns.Remove(movedItem);
                _orderedColumns.Add(movedItem);
            }
        }

        private void PickOutOrderedSelectionButton_Click(object sender, EventArgs e)
        {
            queryChanged = true;
            while (_orderedColumns.Count > 0)
            {
                var movedItem = _orderedColumns.First();
                movedItem.Order = ColumnInfo.Ordering.None;
                _orderedColumns.Remove(movedItem);
                _notOrderedColumns.Add(movedItem);
            }
        }

        private void OrderedColumnsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderedColumnsListBox.SelectedIndex == -1)
            {
                orderVarsPanel.Visible = false;
                return;
            }
            orderVarsPanel.Visible = true;
            switch ((orderedColumnsListBox.SelectedItem as ColumnInfo).Order)
            {
                case ColumnInfo.Ordering.None:
                {
                    break;
                }
                case ColumnInfo.Ordering.Ascending:
                {
                    ascOrderVar.Checked = true;
                    break;
                }
                case ColumnInfo.Ordering.Descending:
                {
                    descOrderVar.Checked = true;
                    break;
                }
            }
        }

        private void DescOrderVar_CheckedChanged(object sender, EventArgs e)
        {
            queryChanged = true;
            if (orderedColumnsListBox.Items.Count == 0)
                return;
            (orderedColumnsListBox.SelectedItem as ColumnInfo).Order = descOrderVar.Checked
                ? ColumnInfo.Ordering.Descending
                : ColumnInfo.Ordering.Ascending;
        }

        private void AscOrderVar_CheckedChanged(object sender, EventArgs e)
        {
            queryChanged = true;
            if (orderedColumnsListBox.Items.Count == 0)
                return;
            (orderedColumnsListBox.SelectedItem as ColumnInfo).Order = ascOrderVar.Checked
                ? ColumnInfo.Ordering.Ascending
                : ColumnInfo.Ordering.Descending;
        }

        private void UpdateNotOrderedUi(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    {
                        addOrderedColumnButton.Enabled = _notOrderedColumns.Count > 0;
                        break;
                    }
                case ListChangedType.ItemAdded:
                    {
                        addOrderedColumnButton.Enabled = true;
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        addOrderedColumnButton.Enabled = _notOrderedColumns.Count > 0;
                        break;
                    }
            }
            selectAllColsButton.Enabled = addOrderedColumnButton.Enabled;
        }

        private void UpdateOrderedUi(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    {
                        if (_orderedColumns.Count > 0)
                            return;
                        orderVarsPanel.Visible = false;
                        pickOutOrderedColumnButton.Enabled = false;
                        break;
                    }
                case ListChangedType.ItemAdded:
                    {
                        orderedColumnsListBox.SelectedIndex = orderedColumnsListBox.Items.Count - 1;
                        ascOrderVar.Checked = true;
                        orderVarsPanel.Visible = true;
                        pickOutOrderedColumnButton.Enabled = true;
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        var enable = _orderedColumns.Count > 0;
                        orderVarsPanel.Visible = enable;
                        pickOutOrderedColumnButton.Enabled = enable;
                        break;
                    }
            }
            pickOutOrderedSelectionButton.Enabled = pickOutOrderedColumnButton.Enabled;
        }
    }
}