namespace QueryConstructor
{
    partial class ConstructorForm
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
            this.components = new System.ComponentModel.Container();
            this.pagesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pagesControl = new System.Windows.Forms.TabControl();
            this.columnsPage = new System.Windows.Forms.TabPage();
            this.fieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.allColsLabel = new System.Windows.Forms.Label();
            this.selectedColsLabel = new System.Windows.Forms.Label();
            this.fieldsButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectFieldButton = new System.Windows.Forms.Button();
            this.pickOutFieldButton = new System.Windows.Forms.Button();
            this.selectAllFieldsButton = new System.Windows.Forms.Button();
            this.pickOutSelectionButton = new System.Windows.Forms.Button();
            this.restOfColumnsListBox = new System.Windows.Forms.ListBox();
            this.selectedColumnsListBox = new System.Windows.Forms.ListBox();
            this.conditionsPage = new System.Windows.Forms.TabPage();
            this.critPanel = new System.Windows.Forms.TableLayoutPanel();
            this.condsDGV = new System.Windows.Forms.DataGridView();
            this.colNameDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logOpDGVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.critCustomizerPannel = new System.Windows.Forms.TableLayoutPanel();
            this.addCondButton = new System.Windows.Forms.Button();
            this.critPropsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colLabel = new System.Windows.Forms.Label();
            this.critLabel = new System.Windows.Forms.Label();
            this.valLabel = new System.Windows.Forms.Label();
            this.logOpLabel = new System.Windows.Forms.Label();
            this.logOpComboBox = new System.Windows.Forms.ComboBox();
            this.logicOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colComboBox = new System.Windows.Forms.ComboBox();
            this.columnInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.critComboBox = new System.Windows.Forms.ComboBox();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.orderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderColsLabel = new System.Windows.Forms.Label();
            this.orderingOrderLabel = new System.Windows.Forms.Label();
            this.orderVarsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderVarsGroup = new System.Windows.Forms.GroupBox();
            this.descOrderVar = new System.Windows.Forms.RadioButton();
            this.ascOrderVar = new System.Windows.Forms.RadioButton();
            this.moveOrderButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addOrderedColumnButton = new System.Windows.Forms.Button();
            this.pickOutOrderedColumnButton = new System.Windows.Forms.Button();
            this.selectAllColsButton = new System.Windows.Forms.Button();
            this.pickOutOrderedSelectionButton = new System.Windows.Forms.Button();
            this.notOrderedColsListBox = new System.Windows.Forms.ListBox();
            this.orderedColumnsListBox = new System.Windows.Forms.ListBox();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.resultDGV = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewQueryButton = new System.Windows.Forms.Button();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.customizeConnButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colsInfoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pagesPanel.SuspendLayout();
            this.pagesControl.SuspendLayout();
            this.columnsPage.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
            this.fieldsButtonsPanel.SuspendLayout();
            this.conditionsPage.SuspendLayout();
            this.critPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            this.critCustomizerPannel.SuspendLayout();
            this.critPropsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logicOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoBindingSource)).BeginInit();
            this.orderPage.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.orderVarsPanel.SuspendLayout();
            this.orderVarsGroup.SuspendLayout();
            this.moveOrderButtonsPanel.SuspendLayout();
            this.resultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.interfacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagesPanel
            // 
            this.pagesPanel.ColumnCount = 3;
            this.pagesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.086957F));
            this.pagesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.82609F));
            this.pagesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.086957F));
            this.pagesPanel.Controls.Add(this.pagesControl, 1, 0);
            this.pagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesPanel.Location = new System.Drawing.Point(3, 39);
            this.pagesPanel.Name = "pagesPanel";
            this.pagesPanel.RowCount = 1;
            this.pagesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesPanel.Size = new System.Drawing.Size(1002, 642);
            this.pagesPanel.TabIndex = 2;
            // 
            // pagesControl
            // 
            this.pagesControl.Controls.Add(this.columnsPage);
            this.pagesControl.Controls.Add(this.conditionsPage);
            this.pagesControl.Controls.Add(this.orderPage);
            this.pagesControl.Controls.Add(this.resultPage);
            this.pagesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesControl.Location = new System.Drawing.Point(13, 3);
            this.pagesControl.Name = "pagesControl";
            this.pagesControl.SelectedIndex = 0;
            this.pagesControl.Size = new System.Drawing.Size(974, 636);
            this.pagesControl.TabIndex = 3;
            // 
            // columnsPage
            // 
            this.columnsPage.Controls.Add(this.fieldsPanel);
            this.columnsPage.Location = new System.Drawing.Point(4, 30);
            this.columnsPage.Name = "columnsPage";
            this.columnsPage.Padding = new System.Windows.Forms.Padding(3);
            this.columnsPage.Size = new System.Drawing.Size(966, 602);
            this.columnsPage.TabIndex = 0;
            this.columnsPage.Text = "Поля";
            this.columnsPage.UseVisualStyleBackColor = true;
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.ColumnCount = 5;
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.fieldsPanel.Controls.Add(this.allColsLabel, 1, 0);
            this.fieldsPanel.Controls.Add(this.selectedColsLabel, 3, 0);
            this.fieldsPanel.Controls.Add(this.fieldsButtonsPanel, 2, 1);
            this.fieldsPanel.Controls.Add(this.restOfColumnsListBox, 1, 1);
            this.fieldsPanel.Controls.Add(this.selectedColumnsListBox, 3, 1);
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsPanel.Location = new System.Drawing.Point(3, 3);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.RowCount = 3;
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.fieldsPanel.Size = new System.Drawing.Size(960, 596);
            this.fieldsPanel.TabIndex = 0;
            // 
            // allColsLabel
            // 
            this.allColsLabel.AutoSize = true;
            this.allColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allColsLabel.Location = new System.Drawing.Point(51, 0);
            this.allColsLabel.Name = "allColsLabel";
            this.allColsLabel.Size = new System.Drawing.Size(397, 29);
            this.allColsLabel.TabIndex = 0;
            this.allColsLabel.Text = "Все поля";
            this.allColsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedColsLabel
            // 
            this.selectedColsLabel.AutoSize = true;
            this.selectedColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedColsLabel.Location = new System.Drawing.Point(511, 0);
            this.selectedColsLabel.Name = "selectedColsLabel";
            this.selectedColsLabel.Size = new System.Drawing.Size(397, 29);
            this.selectedColsLabel.TabIndex = 1;
            this.selectedColsLabel.Text = "Выбранные поля";
            this.selectedColsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fieldsButtonsPanel
            // 
            this.fieldsButtonsPanel.ColumnCount = 3;
            this.fieldsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.fieldsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.fieldsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.fieldsButtonsPanel.Controls.Add(this.selectFieldButton, 1, 1);
            this.fieldsButtonsPanel.Controls.Add(this.pickOutFieldButton, 1, 3);
            this.fieldsButtonsPanel.Controls.Add(this.selectAllFieldsButton, 1, 5);
            this.fieldsButtonsPanel.Controls.Add(this.pickOutSelectionButton, 1, 7);
            this.fieldsButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsButtonsPanel.Location = new System.Drawing.Point(454, 32);
            this.fieldsButtonsPanel.Name = "fieldsButtonsPanel";
            this.fieldsButtonsPanel.RowCount = 9;
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.fieldsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.fieldsButtonsPanel.Size = new System.Drawing.Size(51, 530);
            this.fieldsButtonsPanel.TabIndex = 2;
            // 
            // selectFieldButton
            // 
            this.selectFieldButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFieldButton.Enabled = false;
            this.selectFieldButton.Location = new System.Drawing.Point(4, 146);
            this.selectFieldButton.Name = "selectFieldButton";
            this.selectFieldButton.Size = new System.Drawing.Size(42, 47);
            this.selectFieldButton.TabIndex = 0;
            this.selectFieldButton.Text = ">";
            this.selectFieldButton.UseVisualStyleBackColor = true;
            this.selectFieldButton.Click += new System.EventHandler(this.SelectFieldButton_Click);
            // 
            // pickOutFieldButton
            // 
            this.pickOutFieldButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickOutFieldButton.Enabled = false;
            this.pickOutFieldButton.Location = new System.Drawing.Point(4, 209);
            this.pickOutFieldButton.Name = "pickOutFieldButton";
            this.pickOutFieldButton.Size = new System.Drawing.Size(42, 47);
            this.pickOutFieldButton.TabIndex = 1;
            this.pickOutFieldButton.Text = "<";
            this.pickOutFieldButton.UseVisualStyleBackColor = true;
            this.pickOutFieldButton.Click += new System.EventHandler(this.PickOutFieldButton_Click);
            // 
            // selectAllFieldsButton
            // 
            this.selectAllFieldsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllFieldsButton.Enabled = false;
            this.selectAllFieldsButton.Location = new System.Drawing.Point(4, 272);
            this.selectAllFieldsButton.Name = "selectAllFieldsButton";
            this.selectAllFieldsButton.Size = new System.Drawing.Size(42, 47);
            this.selectAllFieldsButton.TabIndex = 2;
            this.selectAllFieldsButton.Text = ">>";
            this.selectAllFieldsButton.UseVisualStyleBackColor = true;
            this.selectAllFieldsButton.Click += new System.EventHandler(this.SelectAllFieldsButton_Click);
            // 
            // pickOutSelectionButton
            // 
            this.pickOutSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickOutSelectionButton.Enabled = false;
            this.pickOutSelectionButton.Location = new System.Drawing.Point(4, 335);
            this.pickOutSelectionButton.Name = "pickOutSelectionButton";
            this.pickOutSelectionButton.Size = new System.Drawing.Size(42, 47);
            this.pickOutSelectionButton.TabIndex = 3;
            this.pickOutSelectionButton.Text = "<<";
            this.pickOutSelectionButton.UseVisualStyleBackColor = true;
            this.pickOutSelectionButton.Click += new System.EventHandler(this.PickOutSelectionButton_Click);
            // 
            // restOfColumnsListBox
            // 
            this.restOfColumnsListBox.DisplayMember = "VisibleName";
            this.restOfColumnsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restOfColumnsListBox.FormattingEnabled = true;
            this.restOfColumnsListBox.ItemHeight = 21;
            this.restOfColumnsListBox.Location = new System.Drawing.Point(51, 32);
            this.restOfColumnsListBox.Name = "restOfColumnsListBox";
            this.restOfColumnsListBox.Size = new System.Drawing.Size(397, 530);
            this.restOfColumnsListBox.TabIndex = 3;
            // 
            // selectedColumnsListBox
            // 
            this.selectedColumnsListBox.DisplayMember = "VisibleName";
            this.selectedColumnsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedColumnsListBox.FormattingEnabled = true;
            this.selectedColumnsListBox.ItemHeight = 21;
            this.selectedColumnsListBox.Location = new System.Drawing.Point(511, 32);
            this.selectedColumnsListBox.Name = "selectedColumnsListBox";
            this.selectedColumnsListBox.Size = new System.Drawing.Size(397, 530);
            this.selectedColumnsListBox.TabIndex = 4;
            // 
            // conditionsPage
            // 
            this.conditionsPage.Controls.Add(this.critPanel);
            this.conditionsPage.Location = new System.Drawing.Point(4, 30);
            this.conditionsPage.Name = "conditionsPage";
            this.conditionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.conditionsPage.Size = new System.Drawing.Size(966, 602);
            this.conditionsPage.TabIndex = 1;
            this.conditionsPage.Text = "Условия";
            this.conditionsPage.UseVisualStyleBackColor = true;
            // 
            // critPanel
            // 
            this.critPanel.ColumnCount = 1;
            this.critPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.critPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.critPanel.Controls.Add(this.condsDGV, 0, 0);
            this.critPanel.Controls.Add(this.critCustomizerPannel, 0, 4);
            this.critPanel.Controls.Add(this.critPropsPanel, 0, 2);
            this.critPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.critPanel.Location = new System.Drawing.Point(3, 3);
            this.critPanel.Name = "critPanel";
            this.critPanel.RowCount = 5;
            this.critPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79F));
            this.critPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.critPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.critPanel.Size = new System.Drawing.Size(960, 596);
            this.critPanel.TabIndex = 0;
            // 
            // condsDGV
            // 
            this.condsDGV.AllowUserToAddRows = false;
            this.condsDGV.AutoGenerateColumns = false;
            this.condsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.condsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.condsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameDGVCol,
            this.critDGVCol,
            this.valDGVCol,
            this.logOpDGVCol});
            this.condsDGV.DataSource = this.conditionBindingSource;
            this.condsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.condsDGV.Location = new System.Drawing.Point(3, 3);
            this.condsDGV.MultiSelect = false;
            this.condsDGV.Name = "condsDGV";
            this.condsDGV.ReadOnly = true;
            this.condsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.condsDGV.Size = new System.Drawing.Size(954, 464);
            this.condsDGV.TabIndex = 4;
            this.condsDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.condsDGV_UserDeletingRow);
            // 
            // colNameDGVCol
            // 
            this.colNameDGVCol.DataPropertyName = "Column";
            this.colNameDGVCol.HeaderText = "Имя поля";
            this.colNameDGVCol.Name = "colNameDGVCol";
            this.colNameDGVCol.ReadOnly = true;
            this.colNameDGVCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // critDGVCol
            // 
            this.critDGVCol.DataPropertyName = "Criterion";
            this.critDGVCol.HeaderText = "Критерий";
            this.critDGVCol.Name = "critDGVCol";
            this.critDGVCol.ReadOnly = true;
            this.critDGVCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // valDGVCol
            // 
            this.valDGVCol.DataPropertyName = "Value";
            this.valDGVCol.HeaderText = "Значение";
            this.valDGVCol.Name = "valDGVCol";
            this.valDGVCol.ReadOnly = true;
            // 
            // logOpDGVCol
            // 
            this.logOpDGVCol.DataPropertyName = "LogicOp";
            this.logOpDGVCol.HeaderText = "Связка";
            this.logOpDGVCol.Name = "logOpDGVCol";
            this.logOpDGVCol.ReadOnly = true;
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataSource = typeof(QueryConstructor.Condition);
            // 
            // critCustomizerPannel
            // 
            this.critCustomizerPannel.ColumnCount = 3;
            this.critCustomizerPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.critCustomizerPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.critCustomizerPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critCustomizerPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.critCustomizerPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.critCustomizerPannel.Controls.Add(this.addCondButton, 1, 0);
            this.critCustomizerPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.critCustomizerPannel.Location = new System.Drawing.Point(3, 554);
            this.critCustomizerPannel.Name = "critCustomizerPannel";
            this.critCustomizerPannel.RowCount = 1;
            this.critCustomizerPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.critCustomizerPannel.Size = new System.Drawing.Size(954, 39);
            this.critCustomizerPannel.TabIndex = 5;
            // 
            // addCondButton
            // 
            this.addCondButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCondButton.Enabled = false;
            this.addCondButton.Location = new System.Drawing.Point(747, 3);
            this.addCondButton.Name = "addCondButton";
            this.addCondButton.Size = new System.Drawing.Size(184, 33);
            this.addCondButton.TabIndex = 0;
            this.addCondButton.Text = "Добавить";
            this.addCondButton.UseVisualStyleBackColor = true;
            this.addCondButton.Click += new System.EventHandler(this.addCritButton_Click);
            // 
            // critPropsPanel
            // 
            this.critPropsPanel.ColumnCount = 9;
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.critPropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.critPropsPanel.Controls.Add(this.colLabel, 1, 0);
            this.critPropsPanel.Controls.Add(this.critLabel, 3, 0);
            this.critPropsPanel.Controls.Add(this.valLabel, 5, 0);
            this.critPropsPanel.Controls.Add(this.logOpLabel, 7, 0);
            this.critPropsPanel.Controls.Add(this.logOpComboBox, 7, 1);
            this.critPropsPanel.Controls.Add(this.colComboBox, 1, 1);
            this.critPropsPanel.Controls.Add(this.critComboBox, 3, 1);
            this.critPropsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.critPropsPanel.Location = new System.Drawing.Point(3, 484);
            this.critPropsPanel.Name = "critPropsPanel";
            this.critPropsPanel.RowCount = 2;
            this.critPropsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.critPropsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.critPropsPanel.Size = new System.Drawing.Size(954, 53);
            this.critPropsPanel.TabIndex = 6;
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colLabel.Location = new System.Drawing.Point(22, 0);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(327, 21);
            this.colLabel.TabIndex = 0;
            this.colLabel.Text = "Имя поля";
            // 
            // critLabel
            // 
            this.critLabel.AutoSize = true;
            this.critLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.critLabel.Location = new System.Drawing.Point(374, 0);
            this.critLabel.Name = "critLabel";
            this.critLabel.Size = new System.Drawing.Size(137, 21);
            this.critLabel.TabIndex = 1;
            this.critLabel.Text = "Критерий";
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valLabel.Location = new System.Drawing.Point(536, 0);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(280, 21);
            this.valLabel.TabIndex = 2;
            this.valLabel.Text = "Значение";
            // 
            // logOpLabel
            // 
            this.logOpLabel.AutoSize = true;
            this.logOpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOpLabel.Location = new System.Drawing.Point(841, 0);
            this.logOpLabel.Name = "logOpLabel";
            this.logOpLabel.Size = new System.Drawing.Size(89, 21);
            this.logOpLabel.TabIndex = 3;
            this.logOpLabel.Text = "Связка";
            // 
            // logOpComboBox
            // 
            this.logOpComboBox.DataSource = this.logicOperationBindingSource;
            this.logOpComboBox.DisplayMember = "VisibleName";
            this.logOpComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logOpComboBox.FormattingEnabled = true;
            this.logOpComboBox.Location = new System.Drawing.Point(841, 24);
            this.logOpComboBox.Name = "logOpComboBox";
            this.logOpComboBox.Size = new System.Drawing.Size(89, 29);
            this.logOpComboBox.TabIndex = 4;
            // 
            // logicOperationBindingSource
            // 
            this.logicOperationBindingSource.DataSource = typeof(QueryConstructor.LogicOperation);
            // 
            // colComboBox
            // 
            this.colComboBox.DataSource = this.columnInfoBindingSource;
            this.colComboBox.DisplayMember = "VisibleName";
            this.colComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colComboBox.FormattingEnabled = true;
            this.colComboBox.Location = new System.Drawing.Point(22, 24);
            this.colComboBox.Name = "colComboBox";
            this.colComboBox.Size = new System.Drawing.Size(327, 29);
            this.colComboBox.TabIndex = 5;
            this.colComboBox.SelectedIndexChanged += new System.EventHandler(this.colComboBox_SelectedIndexChanged);
            this.colComboBox.BindingContextChanged += new System.EventHandler(this.colComboBox_BindingContextChanged);
            // 
            // columnInfoBindingSource
            // 
            this.columnInfoBindingSource.DataSource = typeof(QueryConstructor.ColumnInfo);
            // 
            // critComboBox
            // 
            this.critComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.critComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.critComboBox.FormattingEnabled = true;
            this.critComboBox.Location = new System.Drawing.Point(374, 24);
            this.critComboBox.Name = "critComboBox";
            this.critComboBox.Size = new System.Drawing.Size(137, 29);
            this.critComboBox.TabIndex = 6;
            this.critComboBox.DataSourceChanged += new System.EventHandler(this.critComboBox_DataSourceChanged);
            // 
            // orderPage
            // 
            this.orderPage.Controls.Add(this.orderPanel);
            this.orderPage.Location = new System.Drawing.Point(4, 30);
            this.orderPage.Name = "orderPage";
            this.orderPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderPage.Size = new System.Drawing.Size(966, 602);
            this.orderPage.TabIndex = 2;
            this.orderPage.Text = "Порядок";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // orderPanel
            // 
            this.orderPanel.ColumnCount = 7;
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.orderPanel.Controls.Add(this.orderColsLabel, 1, 0);
            this.orderPanel.Controls.Add(this.orderingOrderLabel, 3, 0);
            this.orderPanel.Controls.Add(this.orderVarsPanel, 5, 1);
            this.orderPanel.Controls.Add(this.moveOrderButtonsPanel, 2, 1);
            this.orderPanel.Controls.Add(this.notOrderedColsListBox, 1, 1);
            this.orderPanel.Controls.Add(this.orderedColumnsListBox, 3, 1);
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPanel.Location = new System.Drawing.Point(3, 3);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.RowCount = 3;
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.orderPanel.Size = new System.Drawing.Size(960, 596);
            this.orderPanel.TabIndex = 0;
            // 
            // orderColsLabel
            // 
            this.orderColsLabel.AutoSize = true;
            this.orderColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderColsLabel.Location = new System.Drawing.Point(51, 0);
            this.orderColsLabel.Name = "orderColsLabel";
            this.orderColsLabel.Size = new System.Drawing.Size(301, 29);
            this.orderColsLabel.TabIndex = 0;
            this.orderColsLabel.Text = "Выбранные поля";
            this.orderColsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderingOrderLabel
            // 
            this.orderingOrderLabel.AutoSize = true;
            this.orderingOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderingOrderLabel.Location = new System.Drawing.Point(415, 0);
            this.orderingOrderLabel.Name = "orderingOrderLabel";
            this.orderingOrderLabel.Size = new System.Drawing.Size(301, 29);
            this.orderingOrderLabel.TabIndex = 1;
            this.orderingOrderLabel.Text = "Последовательность сортировки";
            this.orderingOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderVarsPanel
            // 
            this.orderVarsPanel.ColumnCount = 1;
            this.orderVarsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderVarsPanel.Controls.Add(this.orderVarsGroup, 0, 1);
            this.orderVarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderVarsPanel.Location = new System.Drawing.Point(770, 32);
            this.orderVarsPanel.Name = "orderVarsPanel";
            this.orderVarsPanel.RowCount = 3;
            this.orderVarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.orderVarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.orderVarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.orderVarsPanel.Size = new System.Drawing.Size(157, 530);
            this.orderVarsPanel.TabIndex = 2;
            this.orderVarsPanel.Visible = false;
            // 
            // orderVarsGroup
            // 
            this.orderVarsGroup.Controls.Add(this.descOrderVar);
            this.orderVarsGroup.Controls.Add(this.ascOrderVar);
            this.orderVarsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderVarsGroup.Location = new System.Drawing.Point(3, 225);
            this.orderVarsGroup.Name = "orderVarsGroup";
            this.orderVarsGroup.Size = new System.Drawing.Size(151, 78);
            this.orderVarsGroup.TabIndex = 0;
            this.orderVarsGroup.TabStop = false;
            this.orderVarsGroup.Text = "Порядок";
            // 
            // descOrderVar
            // 
            this.descOrderVar.AutoSize = true;
            this.descOrderVar.Location = new System.Drawing.Point(6, 40);
            this.descOrderVar.Name = "descOrderVar";
            this.descOrderVar.Size = new System.Drawing.Size(128, 25);
            this.descOrderVar.TabIndex = 1;
            this.descOrderVar.TabStop = true;
            this.descOrderVar.Text = "Убывающий";
            this.descOrderVar.UseVisualStyleBackColor = true;
            this.descOrderVar.CheckedChanged += new System.EventHandler(this.DescOrderVar_CheckedChanged);
            // 
            // ascOrderVar
            // 
            this.ascOrderVar.AutoSize = true;
            this.ascOrderVar.Location = new System.Drawing.Point(6, 19);
            this.ascOrderVar.Name = "ascOrderVar";
            this.ascOrderVar.Size = new System.Drawing.Size(149, 25);
            this.ascOrderVar.TabIndex = 0;
            this.ascOrderVar.TabStop = true;
            this.ascOrderVar.Text = "Возрастающий";
            this.ascOrderVar.UseVisualStyleBackColor = true;
            this.ascOrderVar.CheckedChanged += new System.EventHandler(this.AscOrderVar_CheckedChanged);
            // 
            // moveOrderButtonsPanel
            // 
            this.moveOrderButtonsPanel.ColumnCount = 3;
            this.moveOrderButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.moveOrderButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.moveOrderButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.moveOrderButtonsPanel.Controls.Add(this.addOrderedColumnButton, 1, 1);
            this.moveOrderButtonsPanel.Controls.Add(this.pickOutOrderedColumnButton, 1, 3);
            this.moveOrderButtonsPanel.Controls.Add(this.selectAllColsButton, 1, 5);
            this.moveOrderButtonsPanel.Controls.Add(this.pickOutOrderedSelectionButton, 1, 7);
            this.moveOrderButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveOrderButtonsPanel.Location = new System.Drawing.Point(358, 32);
            this.moveOrderButtonsPanel.Name = "moveOrderButtonsPanel";
            this.moveOrderButtonsPanel.RowCount = 9;
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.moveOrderButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.moveOrderButtonsPanel.Size = new System.Drawing.Size(51, 530);
            this.moveOrderButtonsPanel.TabIndex = 3;
            // 
            // addOrderedColumnButton
            // 
            this.addOrderedColumnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrderedColumnButton.Enabled = false;
            this.addOrderedColumnButton.Location = new System.Drawing.Point(4, 146);
            this.addOrderedColumnButton.Name = "addOrderedColumnButton";
            this.addOrderedColumnButton.Size = new System.Drawing.Size(42, 47);
            this.addOrderedColumnButton.TabIndex = 0;
            this.addOrderedColumnButton.Text = ">";
            this.addOrderedColumnButton.UseVisualStyleBackColor = true;
            this.addOrderedColumnButton.Click += new System.EventHandler(this.addOrderedColumnButton_Click);
            // 
            // pickOutOrderedColumnButton
            // 
            this.pickOutOrderedColumnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickOutOrderedColumnButton.Enabled = false;
            this.pickOutOrderedColumnButton.Location = new System.Drawing.Point(4, 209);
            this.pickOutOrderedColumnButton.Name = "pickOutOrderedColumnButton";
            this.pickOutOrderedColumnButton.Size = new System.Drawing.Size(42, 47);
            this.pickOutOrderedColumnButton.TabIndex = 1;
            this.pickOutOrderedColumnButton.Text = "<";
            this.pickOutOrderedColumnButton.UseVisualStyleBackColor = true;
            this.pickOutOrderedColumnButton.Click += new System.EventHandler(this.PickOutOrderedColumnButton_Click);
            // 
            // selectAllColsButton
            // 
            this.selectAllColsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllColsButton.Enabled = false;
            this.selectAllColsButton.Location = new System.Drawing.Point(4, 272);
            this.selectAllColsButton.Name = "selectAllColsButton";
            this.selectAllColsButton.Size = new System.Drawing.Size(42, 47);
            this.selectAllColsButton.TabIndex = 2;
            this.selectAllColsButton.Text = ">>";
            this.selectAllColsButton.UseVisualStyleBackColor = true;
            this.selectAllColsButton.Click += new System.EventHandler(this.SelectAllColsButton_Click);
            // 
            // pickOutOrderedSelectionButton
            // 
            this.pickOutOrderedSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickOutOrderedSelectionButton.Enabled = false;
            this.pickOutOrderedSelectionButton.Location = new System.Drawing.Point(4, 335);
            this.pickOutOrderedSelectionButton.Name = "pickOutOrderedSelectionButton";
            this.pickOutOrderedSelectionButton.Size = new System.Drawing.Size(42, 47);
            this.pickOutOrderedSelectionButton.TabIndex = 3;
            this.pickOutOrderedSelectionButton.Text = "<<";
            this.pickOutOrderedSelectionButton.UseVisualStyleBackColor = true;
            this.pickOutOrderedSelectionButton.Click += new System.EventHandler(this.PickOutOrderedSelectionButton_Click);
            // 
            // notOrderedColsListBox
            // 
            this.notOrderedColsListBox.DisplayMember = "VisibleName";
            this.notOrderedColsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notOrderedColsListBox.FormattingEnabled = true;
            this.notOrderedColsListBox.ItemHeight = 21;
            this.notOrderedColsListBox.Location = new System.Drawing.Point(51, 32);
            this.notOrderedColsListBox.Name = "notOrderedColsListBox";
            this.notOrderedColsListBox.Size = new System.Drawing.Size(301, 530);
            this.notOrderedColsListBox.TabIndex = 4;
            // 
            // orderedColumnsListBox
            // 
            this.orderedColumnsListBox.DisplayMember = "VisibleName";
            this.orderedColumnsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderedColumnsListBox.FormattingEnabled = true;
            this.orderedColumnsListBox.ItemHeight = 21;
            this.orderedColumnsListBox.Location = new System.Drawing.Point(415, 32);
            this.orderedColumnsListBox.Name = "orderedColumnsListBox";
            this.orderedColumnsListBox.Size = new System.Drawing.Size(301, 530);
            this.orderedColumnsListBox.TabIndex = 5;
            this.orderedColumnsListBox.SelectedIndexChanged += new System.EventHandler(this.OrderedColumnsListBox_SelectedIndexChanged);
            // 
            // resultPage
            // 
            this.resultPage.Controls.Add(this.resultDGV);
            this.resultPage.Location = new System.Drawing.Point(4, 30);
            this.resultPage.Name = "resultPage";
            this.resultPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultPage.Size = new System.Drawing.Size(966, 602);
            this.resultPage.TabIndex = 3;
            this.resultPage.Text = "Результат";
            this.resultPage.UseVisualStyleBackColor = true;
            // 
            // resultDGV
            // 
            this.resultDGV.AllowUserToAddRows = false;
            this.resultDGV.AllowUserToDeleteRows = false;
            this.resultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDGV.Location = new System.Drawing.Point(3, 3);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.ReadOnly = true;
            this.resultDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDGV.Size = new System.Drawing.Size(960, 596);
            this.resultDGV.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 7;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.buttonsPanel.Controls.Add(this.viewQueryButton, 1, 0);
            this.buttonsPanel.Controls.Add(this.executeQueryButton, 3, 0);
            this.buttonsPanel.Controls.Add(this.resetButton, 5, 0);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 687);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Size = new System.Drawing.Size(1002, 39);
            this.buttonsPanel.TabIndex = 1;
            // 
            // viewQueryButton
            // 
            this.viewQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewQueryButton.Enabled = false;
            this.viewQueryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewQueryButton.Location = new System.Drawing.Point(253, 3);
            this.viewQueryButton.Name = "viewQueryButton";
            this.viewQueryButton.Size = new System.Drawing.Size(194, 33);
            this.viewQueryButton.TabIndex = 0;
            this.viewQueryButton.Text = "Просмотр SQL";
            this.viewQueryButton.UseVisualStyleBackColor = true;
            this.viewQueryButton.Click += new System.EventHandler(this.ViewQueryButton_Click);
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.executeQueryButton.Enabled = false;
            this.executeQueryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeQueryButton.Location = new System.Drawing.Point(503, 3);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(244, 33);
            this.executeQueryButton.TabIndex = 1;
            this.executeQueryButton.Text = "Выполнить запрос";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(803, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 33);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeConnButton,
            this.colsInfoButton});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 36);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Главное меню";
            // 
            // customizeConnButton
            // 
            this.customizeConnButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customizeConnButton.Name = "customizeConnButton";
            this.customizeConnButton.Size = new System.Drawing.Size(224, 32);
            this.customizeConnButton.Text = "Настроить соединение";
            this.customizeConnButton.Click += new System.EventHandler(this.CustomizeConnButton_Click);
            // 
            // colsInfoButton
            // 
            this.colsInfoButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colsInfoButton.Name = "colsInfoButton";
            this.colsInfoButton.Size = new System.Drawing.Size(304, 32);
            this.colsInfoButton.Text = "Информация обо всех столбцах";
            this.colsInfoButton.Click += new System.EventHandler(this.ColsInfoButton_Click);
            // 
            // interfacePanel
            // 
            this.interfacePanel.ColumnCount = 1;
            this.interfacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.interfacePanel.Controls.Add(this.mainMenu, 0, 0);
            this.interfacePanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.interfacePanel.Controls.Add(this.pagesPanel, 0, 1);
            this.interfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interfacePanel.Location = new System.Drawing.Point(0, 0);
            this.interfacePanel.Name = "interfacePanel";
            this.interfacePanel.RowCount = 3;
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.interfacePanel.Size = new System.Drawing.Size(1008, 729);
            this.interfacePanel.TabIndex = 0;
            // 
            // ConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.interfacePanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConstructorForm";
            this.Load += new System.EventHandler(this.ConstructorForm_Load);
            this.pagesPanel.ResumeLayout(false);
            this.pagesControl.ResumeLayout(false);
            this.columnsPage.ResumeLayout(false);
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.fieldsButtonsPanel.ResumeLayout(false);
            this.conditionsPage.ResumeLayout(false);
            this.critPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.condsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            this.critCustomizerPannel.ResumeLayout(false);
            this.critPropsPanel.ResumeLayout(false);
            this.critPropsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logicOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoBindingSource)).EndInit();
            this.orderPage.ResumeLayout(false);
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.orderVarsPanel.ResumeLayout(false);
            this.orderVarsGroup.ResumeLayout(false);
            this.orderVarsGroup.PerformLayout();
            this.moveOrderButtonsPanel.ResumeLayout(false);
            this.resultPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.interfacePanel.ResumeLayout(false);
            this.interfacePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pagesPanel;
        private System.Windows.Forms.TabControl pagesControl;
        private System.Windows.Forms.TabPage columnsPage;
        private System.Windows.Forms.TableLayoutPanel fieldsPanel;
        private System.Windows.Forms.Label allColsLabel;
        private System.Windows.Forms.Label selectedColsLabel;
        private System.Windows.Forms.TableLayoutPanel fieldsButtonsPanel;
        private System.Windows.Forms.Button selectFieldButton;
        private System.Windows.Forms.Button pickOutFieldButton;
        private System.Windows.Forms.Button selectAllFieldsButton;
        private System.Windows.Forms.Button pickOutSelectionButton;
        private System.Windows.Forms.ListBox restOfColumnsListBox;
        private System.Windows.Forms.ListBox selectedColumnsListBox;
        private System.Windows.Forms.TabPage conditionsPage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TableLayoutPanel orderPanel;
        private System.Windows.Forms.Label orderColsLabel;
        private System.Windows.Forms.Label orderingOrderLabel;
        private System.Windows.Forms.TableLayoutPanel orderVarsPanel;
        private System.Windows.Forms.GroupBox orderVarsGroup;
        private System.Windows.Forms.RadioButton descOrderVar;
        private System.Windows.Forms.RadioButton ascOrderVar;
        private System.Windows.Forms.TableLayoutPanel moveOrderButtonsPanel;
        private System.Windows.Forms.Button addOrderedColumnButton;
        private System.Windows.Forms.Button pickOutOrderedColumnButton;
        private System.Windows.Forms.Button selectAllColsButton;
        private System.Windows.Forms.Button pickOutOrderedSelectionButton;
        private System.Windows.Forms.ListBox notOrderedColsListBox;
        private System.Windows.Forms.ListBox orderedColumnsListBox;
        private System.Windows.Forms.TabPage resultPage;
        private System.Windows.Forms.DataGridView resultDGV;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button viewQueryButton;
        private System.Windows.Forms.Button executeQueryButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem customizeConnButton;
        private System.Windows.Forms.ToolStripMenuItem colsInfoButton;
        private System.Windows.Forms.TableLayoutPanel interfacePanel;
        private System.Windows.Forms.TableLayoutPanel critPanel;
        private System.Windows.Forms.DataGridView condsDGV;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private System.Windows.Forms.TableLayoutPanel critCustomizerPannel;
        private System.Windows.Forms.Button addCondButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn critDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDGVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn logOpDGVCol;
        private System.Windows.Forms.TableLayoutPanel critPropsPanel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label critLabel;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.Label logOpLabel;
        private System.Windows.Forms.ComboBox logOpComboBox;
        private System.Windows.Forms.BindingSource logicOperationBindingSource;
        private System.Windows.Forms.ComboBox colComboBox;
        private System.Windows.Forms.BindingSource columnInfoBindingSource;
        private System.Windows.Forms.ComboBox critComboBox;
    }
}

