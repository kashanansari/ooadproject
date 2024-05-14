using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD
{
    public partial class Form2 : Form
    {
        private BusinessLogicLayer _businessLogic;
        private string _userEmail;

        public Form2()
        {
            InitializeComponent();
            _businessLogic = new BusinessLogicLayer();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userEmail = email.Text;
            string userPassword = password.Text;

            var loginResult = await Task.Run(() => _businessLogic.Login(userEmail, userPassword));

            if (loginResult.isSuccessful)
            {
                MessageBox.Show("Login Successful!");
                _userEmail = userEmail;

                if (loginResult.role == "student")
                {
                    Form7 form7 = new Form7(userEmail);
                    form7.Show();
                }
                else if (loginResult.role == "teacher")
                {
                    Form8 form8 = new Form8(userEmail);
                    form8.Show();
                }
                else
                {
                    MessageBox.Show("Role not recognized!");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
