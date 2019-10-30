using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QueryConstructor
{
    public partial class ConnectionDialog : Form
    {
        public SqlConnectionStringBuilder ConnBuilder { get; }
        private string PreviousDb { get; }

        public ConnectionDialog(string prevServer, string prevDb)
        {
            InitializeComponent();
            ConnBuilder = new SqlConnectionStringBuilder
            {
                DataSource = prevServer,
                InitialCatalog = "master",
                IntegratedSecurity = true
            };
            serverNameLabel.Text = prevServer;
            PreviousDb = prevDb;
        }

        private void ConnectionDialog_Load(object sender, EventArgs e)
        {
            var prevDbFound = false;
            using (var connection = new SqlConnection(ConnBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show(Localization.ServerConnectionFailure, Localization.ServerConnectionFailureCaption);
                    return;
                }
                foreach (DataRow db in connection.GetSchema("Databases").Rows)
                {
                    if (!IsStandardDb(db[0] as string))
                        dbComboBox.Items.Add(db[0]);
                    prevDbFound = prevDbFound || db[0] as string == PreviousDb;
                }
            }
            if (prevDbFound)
                dbComboBox.SelectedItem = PreviousDb;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dbComboBox.SelectedItem.Equals(PreviousDb))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void DbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            ConnBuilder.InitialCatalog = dbComboBox.SelectedItem as string;
        }

        private static bool IsStandardDb(string dbName)
        {
            return dbName == "tempdb" || dbName == "master" || dbName == "model" || dbName == "msdb";
        }
    }
}