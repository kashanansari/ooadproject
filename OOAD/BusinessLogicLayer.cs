using System;
using System.Data;

namespace OOAD
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccess;

        public BusinessLogicLayer()
        {
            _dataAccess = new DataAccessLayer();
        }

        public (bool isSuccessful, string role) Login(string email, string password)
        {
            return _dataAccess.VerifyUserCredentials(email, password);
        }

        public DataTable GetAttendanceData()
        {
            return _dataAccess.GetAttendanceData();
        }

        public bool Signup(string name, string email, string password, string confirmPassword, string role)
        {
            // Check if email is in valid format
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email format");
            }

            // Check if password matches confirm password
            if (password != confirmPassword)
            {
                throw new ArgumentException("Passwords do not match");
            }

            // Check if email already exists
            if (_dataAccess.UserExists(email))
            {
                throw new ArgumentException("User with this email already exists");
            }

            // Save user data
            return _dataAccess.SaveUserData(name, email, password, role);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
