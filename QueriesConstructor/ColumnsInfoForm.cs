using System.ComponentModel;
using System.Windows.Forms;

namespace QueryConstructor
{
    public partial class ColumnsInfoForm : Form
    {
        private BindingList<ColumnInfo> columns { get; }

        public ColumnsInfoForm(BindingList<ColumnInfo> cols)
        {
            InitializeComponent();
            columns = cols;
        }

        private void ColumnsInfoForm_Load(object sender, System.EventArgs e)
        {
            foreach (var column in columns)
            {
                var addedRowIndex = columnsDGV.Rows.Add(column.RealName, column.TableName, column.ValType.Name, column.VisibleName);
                columnsDGV.Rows[addedRowIndex].Tag = column;
            }
        }

        private void ColumnsDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var row = columnsDGV.Rows[e.RowIndex];
            var newVisibleName = row.Cells[e.ColumnIndex].EditedFormattedValue as string;
            if (newVisibleName != null && newVisibleName.Trim() != "") return;
            row.Cells[e.ColumnIndex].ErrorText = "Некорректное отображаемое название";
            e.Cancel = true;
        }

        private void ColumnsDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (columnsDGV.Rows[e.RowIndex].IsNewRow) return;
            columnsDGV[e.ColumnIndex, e.RowIndex].ErrorText = "";
            columns[e.RowIndex].VisibleName = columnsDGV[e.ColumnIndex, e.RowIndex].Value as string;
        }
    }
}