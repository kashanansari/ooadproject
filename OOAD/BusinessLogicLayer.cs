using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccess;

        public BusinessLogicLayer()
        {
            _dataAccess = new DataAccessLayer();
        }

        public bool Login(string email, string password)
        {
            return _dataAccess.VerifyUserCredentials(email, password);
        }
    }
}

