using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSavedSettings();
            txtPassword.PasswordChar = '*';
        }
        private void LoadSavedSettings()
        {
            cboServerIP.Text = Properties.Settings.Default.ServerIP;
            cboServerName.Text = Properties.Settings.Default.ServerName;
            cboUsername.Text = Properties.Settings.Default.Username;
        }

        private void ConnectToServer(string connectionString)
        {
            try
            {
                if (string.IsNullOrEmpty(cboServerIP.Text))
                {
                    MessageBox.Show("Error.Empty fields");
                    return;
                }
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Successfully Done");
                    DatabaseListForm databaseListForm = new DatabaseListForm(connection);
                    databaseListForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(  object sender, EventArgs e)
        {
            string serverIP = cboServerName.Text;
            string connectionString = $"Data Source={serverIP};Integrated Security=True";
            ConnectToServer(connectionString);
            SaveSettings();
        }
        private void btnConnectRemote_Click_1(object sender, EventArgs e)
        {
            string serverIP = cboServerIP.Text;
            string username = cboUsername.Text;
            string password = txtPassword.Text;
            string serverName = cboServerName.Text;

            // Surround the variables with double quotes
            string connectionString = $"Server={serverIP};Database={serverName};User Id=\"Samad\";Password=\"{password}\";";
            ConnectToServer(connectionString);
            SaveSettings();

        }

        private void  connectRmote()
        { }

        private void SaveSettings()
        {
            // Save settings
            Properties.Settings.Default.ServerIP = cboServerIP.Text;
            Properties.Settings.Default.ServerName = cboServerName.Text;
            Properties.Settings.Default.Username = cboUsername.Text;
            Properties.Settings.Default.Save();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
