namespace QueryConstructor
{
    partial class ConnectionDialog
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serverPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serverLabel = new System.Windows.Forms.Label();
            this.dbPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dbLabel = new System.Windows.Forms.Label();
            this.dbComboBox = new System.Windows.Forms.ComboBox();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.serverPanel.SuspendLayout();
            this.dbPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.serverPanel, 0, 0);
            this.mainPanel.Controls.Add(this.dbPanel, 0, 1);
            this.mainPanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Size = new System.Drawing.Size(304, 201);
            this.mainPanel.TabIndex = 0;
            // 
            // serverPanel
            // 
            this.serverPanel.ColumnCount = 1;
            this.serverPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.serverPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.serverPanel.Controls.Add(this.serverLabel, 0, 0);
            this.serverPanel.Controls.Add(this.serverNameLabel, 0, 1);
            this.serverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverPanel.Location = new System.Drawing.Point(3, 3);
            this.serverPanel.Name = "serverPanel";
            this.serverPanel.RowCount = 2;
            this.serverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverPanel.Size = new System.Drawing.Size(298, 74);
            this.serverPanel.TabIndex = 0;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverLabel.Location = new System.Drawing.Point(3, 0);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(292, 37);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Сервер MS SQL";
            this.serverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbPanel
            // 
            this.dbPanel.ColumnCount = 1;
            this.dbPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dbPanel.Controls.Add(this.dbLabel, 0, 0);
            this.dbPanel.Controls.Add(this.dbComboBox, 0, 1);
            this.dbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPanel.Location = new System.Drawing.Point(3, 83);
            this.dbPanel.Name = "dbPanel";
            this.dbPanel.RowCount = 2;
            this.dbPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbPanel.Size = new System.Drawing.Size(298, 74);
            this.dbPanel.TabIndex = 1;
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbLabel.Location = new System.Drawing.Point(3, 0);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(292, 37);
            this.dbLabel.TabIndex = 0;
            this.dbLabel.Text = "База данных";
            this.dbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbComboBox
            // 
            this.dbComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbComboBox.FormattingEnabled = true;
            this.dbComboBox.Location = new System.Drawing.Point(3, 40);
            this.dbComboBox.Name = "dbComboBox";
            this.dbComboBox.Size = new System.Drawing.Size(292, 29);
            this.dbComboBox.TabIndex = 1;
            this.dbComboBox.SelectedIndexChanged += new System.EventHandler(this.DbComboBox_SelectedIndexChanged);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 5;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.buttonsPanel.Controls.Add(this.okButton, 1, 0);
            this.buttonsPanel.Controls.Add(this.cancelButton, 3, 0);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 163);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Size = new System.Drawing.Size(298, 35);
            this.buttonsPanel.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(77, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(53, 29);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(165, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverNameLabel.Location = new System.Drawing.Point(3, 37);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(292, 37);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Имя сервера";
            this.serverNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConnectionDialog";
            this.Text = "Настройка подключения";
            this.Load += new System.EventHandler(this.ConnectionDialog_Load);
            this.mainPanel.ResumeLayout(false);
            this.serverPanel.ResumeLayout(false);
            this.serverPanel.PerformLayout();
            this.dbPanel.ResumeLayout(false);
            this.dbPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel serverPanel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TableLayoutPanel dbPanel;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.ComboBox dbComboBox;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label serverNameLabel;
    }
}