
namespace Code
{
    partial class Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_findname = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTENNV = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbbGIOITINH = new System.Windows.Forms.ComboBox();
            this.pnAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(947, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 47;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tên Nhân Viên Cần Tìm";
            // 
            // tb_findname
            // 
            this.tb_findname.Location = new System.Drawing.Point(221, 194);
            this.tb_findname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_findname.Name = "tb_findname";
            this.tb_findname.Size = new System.Drawing.Size(240, 22);
            this.tb_findname.TabIndex = 45;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(839, 168);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(100, 28);
            this.bt_delete.TabIndex = 44;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(839, 102);
            this.bt_update.Margin = new System.Windows.Forms.Padding(4);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(100, 28);
            this.bt_update.TabIndex = 43;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(839, 36);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 28);
            this.bt_add.TabIndex = 42;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(544, 24);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(240, 22);
            this.txtDIACHI.TabIndex = 41;
            // 
            // txtTENNV
            // 
            this.txtTENNV.Location = new System.Drawing.Point(133, 70);
            this.txtTENNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTENNV.Name = "txtTENNV";
            this.txtTENNV.Size = new System.Drawing.Size(240, 22);
            this.txtTENNV.TabIndex = 40;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(133, 25);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(240, 22);
            this.txtMANV.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã NV";
            // 
            // dtpNGAYSINH
            // 
            this.dtpNGAYSINH.Location = new System.Drawing.Point(133, 115);
            this.dtpNGAYSINH.Name = "dtpNGAYSINH";
            this.dtpNGAYSINH.Size = new System.Drawing.Size(240, 22);
            this.dtpNGAYSINH.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(544, 116);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(240, 22);
            this.txtSDT.TabIndex = 53;
            // 
            // cbbGIOITINH
            // 
            this.cbbGIOITINH.FormattingEnabled = true;
            this.cbbGIOITINH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGIOITINH.Location = new System.Drawing.Point(544, 69);
            this.cbbGIOITINH.Name = "cbbGIOITINH";
            this.cbbGIOITINH.Size = new System.Drawing.Size(240, 24);
            this.cbbGIOITINH.TabIndex = 54;
            // 
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.txtMANV);
            this.pnAdmin.Controls.Add(this.cbbGIOITINH);
            this.pnAdmin.Controls.Add(this.label1);
            this.pnAdmin.Controls.Add(this.txtSDT);
            this.pnAdmin.Controls.Add(this.label2);
            this.pnAdmin.Controls.Add(this.label5);
            this.pnAdmin.Controls.Add(this.label3);
            this.pnAdmin.Controls.Add(this.label6);
            this.pnAdmin.Controls.Add(this.txtTENNV);
            this.pnAdmin.Controls.Add(this.label7);
            this.pnAdmin.Controls.Add(this.txtDIACHI);
            this.pnAdmin.Controls.Add(this.dtpNGAYSINH);
            this.pnAdmin.Location = new System.Drawing.Point(25, 17);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(792, 165);
            this.pnAdmin.TabIndex = 55;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 495);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_findname);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_findname;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENNV;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNGAYSINH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbbGIOITINH;
        private System.Windows.Forms.Panel pnAdmin;
    }
}