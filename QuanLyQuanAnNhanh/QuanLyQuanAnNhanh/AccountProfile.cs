using QuanLyQuanAnNhanh.DAO;
using QuanLyQuanAnNhanh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAnNhanh
{
    public partial class AccountProfile : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public AccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            //txbDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
           // string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                   // if (updateAccount != null)
                    //    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Sai mật khấu");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
