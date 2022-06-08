
namespace QuanLyQuanAnNhanh
{
    partial class fMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFood = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbFood.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFood);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tbFood
            // 
            this.tbFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbFood.Controls.Add(this.panel3);
            this.tbFood.Controls.Add(this.panel2);
            this.tbFood.Controls.Add(this.panel1);
            this.tbFood.Location = new System.Drawing.Point(4, 25);
            this.tbFood.Name = "tbFood";
            this.tbFood.Padding = new System.Windows.Forms.Padding(3);
            this.tbFood.Size = new System.Drawing.Size(802, 511);
            this.tbFood.TabIndex = 0;
            this.tbFood.Text = "Thức ăn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(487, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 262);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.nmFoodPrice);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(7, 206);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(299, 33);
            this.panel8.TabIndex = 6;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(115, 6);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(180, 22);
            this.nmFoodPrice.TabIndex = 7;
            this.nmFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbFoodCategory);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(7, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 33);
            this.panel7.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(115, 3);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(180, 24);
            this.cbFoodCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh mục:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbFoodName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(7, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 33);
            this.panel6.TabIndex = 4;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(115, 6);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(180, 22);
            this.txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbFoodID);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(7, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 33);
            this.panel5.TabIndex = 3;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(115, 6);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(180, 22);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.t);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditFood);
            this.panel2.Controls.Add(this.btnDeleteFood);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Location = new System.Drawing.Point(487, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 56);
            this.panel2.TabIndex = 1;
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditFood.Location = new System.Drawing.Point(229, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(73, 50);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteFood.Location = new System.Drawing.Point(122, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(73, 50);
            this.btnDeleteFood.TabIndex = 2;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddFood.Location = new System.Drawing.Point(20, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(73, 50);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvFood);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 499);
            this.panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(0, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(466, 493);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Controls.Add(this.panel16);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 511);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Danh mục";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Location = new System.Drawing.Point(481, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(309, 262);
            this.panel10.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txbCategoryName);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Location = new System.Drawing.Point(7, 128);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(299, 33);
            this.panel13.TabIndex = 4;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(150, 6);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(145, 22);
            this.txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên danh mục:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbCategoryID);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(7, 89);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(299, 33);
            this.panel14.TabIndex = 3;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(150, 6);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(145, 22);
            this.txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dtgvCategory);
            this.panel16.Location = new System.Drawing.Point(3, 6);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(472, 502);
            this.panel16.TabIndex = 0;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(466, 494);
            this.dtgvCategory.TabIndex = 0;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(825, 552);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý menu";
            this.tabControl1.ResumeLayout(false);
            this.tbFood.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dtgvCategory;
    }
}