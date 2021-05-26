
namespace Code
{
    partial class ProductManage
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
            this.button4 = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 285);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(596, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Về Màn hình chính";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(464, 84);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 30;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(464, 44);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 29;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(464, 7);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 28;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_giaban
            // 
            this.tb_giaban.Location = new System.Drawing.Point(153, 84);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(181, 20);
            this.tb_giaban.TabIndex = 27;
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(153, 49);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(181, 20);
            this.tb_tensp.TabIndex = 26;
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(153, 10);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(181, 20);
            this.tb_masp.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giá Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_giaban);
            this.Controls.Add(this.tb_tensp);
            this.Controls.Add(this.tb_masp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_giaban;
        private System.Windows.Forms.TextBox tb_tensp;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}