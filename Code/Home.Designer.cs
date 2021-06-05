
namespace Code
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userList = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem1,
            this.hóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userList,
            this.changePassword,
            this.logout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // userList
            // 
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(225, 26);
            this.userList.Text = "Danh sách tài khoản";
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(225, 26);
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(225, 26);
            this.logout.Text = "Đăng xuất";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hàngHóaToolStripMenuItem.Text = "Sản Phẩm";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.kháchHàngToolStripMenuItem.Text = "Nhân Viên";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoHóaĐơnToolStripMenuItem,
            this.xemHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            this.tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            this.tạoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.tạoHóaĐơnToolStripMenuItem.Text = "Tạo Hóa Đơn";
            this.tạoHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.tạoHóaĐơnToolStripMenuItem_Click);
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn";
            this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemHóaĐơnToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // kháchHàngToolStripMenuItem1
            // 
            this.kháchHàngToolStripMenuItem1.Name = "kháchHàngToolStripMenuItem1";
            this.kháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.kháchHàngToolStripMenuItem1.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem1.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 503);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userList;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem1;
    }
}