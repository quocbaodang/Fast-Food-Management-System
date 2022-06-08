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
    public partial class fMenu : Form
    {
        BindingSource foodList = new BindingSource();

        public fMenu()
        {

            InitializeComponent();
            dtgvFood.DataSource = foodList;
            LoadFoodList();
            LoadCategoryList();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            AddCategoryBinding();
        }

        public fMenu(DataRow item)
        {

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoadFoodList()
        {
          //  string query = "select * from food";
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            dtgvFood.Columns[0].HeaderText = "Giá";
            dtgvFood.Columns[1].HeaderText = "Mã danh mục";
            dtgvFood.Columns[2].HeaderText = "Tên món";
            dtgvFood.Columns[3].HeaderText = "ID";
        }

        void LoadCategoryList()
        {
            //  string query = "select * from food";
            dtgvCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            dtgvCategory.Columns[0].HeaderText = "Tên danh mục";
        }

        //Biding Food
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        //Biding category
        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            //nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Biding Category in menu food
        private void t(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();
               // if (insertFood != null)
                  //  insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();
                //if (updateFood != null)
                  //  updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadFoodList();
              //  if (deleteFood != null)
                //    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }
 
    }
}
