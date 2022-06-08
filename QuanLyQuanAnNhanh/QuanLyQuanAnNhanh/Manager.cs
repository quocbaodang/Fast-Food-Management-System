using QuanLyQuanAnNhanh.DAO;
using QuanLyQuanAnNhanh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanAnNhanh.DTO.Menu;

namespace QuanLyQuanAnNhanh
{
    public partial class Manager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public Manager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
        }
        #region Method

        void ChangeAccount(int type)
        {
            đổiMậtKhẩuToolStripMenuItem.Enabled = type == 1;
            quảnLýToolStripMenuItem.Enabled = type == 1;
            đăngXuấtToolStripMenuItem.Text += "  (" + LoginAccount.UserName + ")";
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {

            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
            //LoadTable();
        }


        #endregion

        #region Events
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        //Thêm món
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
           // int discount = (int)nmDisCount.Value;

           double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            //double finalTotalPrice = totalPrice;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0} với tổng số tiền là {1}", table.Name, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK);
                {
                    BillDAO.Instance.CheckOut(idBill, (float) totalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }


        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        #endregion

        private void xemDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales f = new Sales();
            f.ShowDialog();
        }

        private void quảnLýMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMenu f = new fMenu();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile(LoginAccount);
          //  f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
