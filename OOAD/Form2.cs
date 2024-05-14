using System;
using System.Windows.Forms;

namespace OOAD
{
    public partial class Form2 : Form
    {
        private BusinessLogicLayer _businessLogic;

        public Form2()
        {
            InitializeComponent();
            _businessLogic = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = email.Text;
            string userPassword = password.Text;

            bool isLoginSuccessful = _businessLogic.Login(userEmail, userPassword);

            if (isLoginSuccessful)
            {
                MessageBox.Show("Login successful congratulations!");
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
    }
}
