namespace QueryConstructor
{
    partial class ColumnsInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnsDGV = new System.Windows.Forms.DataGridView();
            this.colDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibleColNameDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.columnsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // columnsDGV
            // 
            this.columnsDGV.AllowUserToAddRows = false;
            this.columnsDGV.AllowUserToDeleteRows = false;
            this.columnsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.columnsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDGVCol,
            this.tableDGVCol,
            this.colTypeDGVCol,
            this.visibleColNameDGVCol});
            this.columnsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsDGV.Location = new System.Drawing.Point(0, 0);
            this.columnsDGV.Name = "columnsDGV";
            this.columnsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.columnsDGV.Size = new System.Drawing.Size(624, 441);
            this.columnsDGV.TabIndex = 0;
            this.columnsDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ColumnsDGV_CellValidating);
            this.columnsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnsDGV_CellValueChanged);
            // 
            // colDGVCol
            // 
            this.colDGVCol.HeaderText = "Имя поля";
            this.colDGVCol.Name = "colDGVCol";
            this.colDGVCol.ReadOnly = true;
            // 
            // tableDGVCol
            // 
            this.tableDGVCol.HeaderText = "Имя таблицы";
            this.tableDGVCol.Name = "tableDGVCol";
            this.tableDGVCol.ReadOnly = true;
            // 
            // colTypeDGVCol
            // 
            this.colTypeDGVCol.HeaderText = "Тип значения";
            this.colTypeDGVCol.Name = "colTypeDGVCol";
            this.colTypeDGVCol.ReadOnly = true;
            this.colTypeDGVCol.Visible = false;
            // 
            // visibleColNameDGVCol
            // 
            this.visibleColNameDGVCol.HeaderText = "Отображаемое название";
            this.visibleColNameDGVCol.Name = "visibleColNameDGVCol";
            // 
            // ColumnsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.columnsDGV);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColumnsInfoForm";
            this.Text = "Информация о столбцах БД";
            this.Load += new System.EventHandler(this.ColumnsInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView columnsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibleColNameDGVCol;
    }
}