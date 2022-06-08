
namespace QuanLyQuanAnNhanh
{
    partial class AccountProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountProfile));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 47);
            this.panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(199, 12);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(203, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(10, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 47);
            this.panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(199, 12);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(203, 22);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbNewPass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(10, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 47);
            this.panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(199, 12);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(203, 22);
            this.txbNewPass.TabIndex = 1;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu mới:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbReEnterPass);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(10, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 47);
            this.panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.Location = new System.Drawing.Point(199, 12);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(203, 22);
            this.txbReEnterPass.TabIndex = 1;
            this.txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập lại:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(209, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(353, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // AccountProfile
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}