using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD
{
    public partial class DatabaseListForm : Form
    {
        public DatabaseListForm(SqlConnection connection)
        {
            InitializeComponent();
            PopulateDatabaseList(connection);
        }
        private void PopulateDatabaseList(SqlConnection connection)
        {
            DataTable databases = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT name AS DatabaseName FROM sys.databases", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    databases.Load(reader);
                }
            }
            listBoxDatabases.DataSource = databases;
            listBoxDatabases.DisplayMember = "DatabaseName";
        }
       
        private void DatabaseListForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
