using System;
using System.Windows.Forms;

namespace OOAD
{
    public partial class Form5 : Form
    {
        private BusinessLogicLayer _businessLogic;

        public Form5()
        {
            InitializeComponent();
            _businessLogic = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = name.Text;
            string userEmail = email.Text;
            string userPassword = password.Text;
            string confirmPassword = confirmpassword.Text;
            string role ="teacher";

            try
            {
                bool isSignupSuccessful = _businessLogic.Signup(userName, userEmail, userPassword, confirmPassword, role);

                if (isSignupSuccessful)
                {
                    MessageBox.Show("Signup Successful!");
                }
                else
                {
                    MessageBox.Show("Signup failed. Please try again.");
                }

            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
