using QuanLyQuanAnNhanh.DAO;
using QuanLyQuanAnNhanh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyQuanAnNhanh
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}
