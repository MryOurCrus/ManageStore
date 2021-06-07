
namespace Code
{
    partial class Customers
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btUPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(667, 68);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUPDATE
            // 
            this.btUPDATE.Location = new System.Drawing.Point(667, 23);
            this.btUPDATE.Name = "btUPDATE";
            this.btUPDATE.Size = new System.Drawing.Size(75, 23);
            this.btUPDATE.TabIndex = 2;
            this.btUPDATE.Text = "Thay đổi";
            this.btUPDATE.UseVisualStyleBackColor = true;
            this.btUPDATE.Click += new System.EventHandler(this.btUPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT";
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(163, 26);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.ReadOnly = true;
            this.txtMAKH.Size = new System.Drawing.Size(159, 22);
            this.txtMAKH.TabIndex = 7;
            // 
            // txtTENKH
            // 
            this.txtTENKH.Location = new System.Drawing.Point(163, 60);
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(159, 22);
            this.txtTENKH.TabIndex = 8;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(417, 23);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(159, 22);
            this.txtDIACHI.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(417, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(159, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.txtTENKH);
            this.Controls.Add(this.txtMAKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUPDATE);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtSDT;
    }
}