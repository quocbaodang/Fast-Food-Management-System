using QuanLyQuanAnNhanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAnNhanh.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string password)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password /*list*/});

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @password , @newPassword", new object[] { userName, pass, newPass });

            return result > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }


    }
}
