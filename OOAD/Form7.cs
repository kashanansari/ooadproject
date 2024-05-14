using System;
using System.Data;
using System.Windows.Forms;

namespace OOAD
{
    public partial class Form7 : Form
    {
        private BusinessLogicLayer _businessLogic;
        private string _userEmail;

        public Form7(string userEmail)
        {
            InitializeComponent();
            _businessLogic = new BusinessLogicLayer();
            _userEmail = userEmail;
            LoadAttendanceData();
        }

        private void LoadAttendanceData()
        {
            try
            {
                DataTable attendanceData = _businessLogic.GetAttendanceData(_userEmail);
                dataGridView1.DataSource = attendanceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message);
            }
        }
    }

}
