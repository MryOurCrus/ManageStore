
namespace Code
{
    partial class ChangePass
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
            this.userName = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(222, 93);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(154, 20);
            this.userName.TabIndex = 1;
            // 
            // confirmPass
            // 
            this.confirmPass.Location = new System.Drawing.Point(222, 198);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(154, 20);
            this.confirmPass.TabIndex = 2;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(222, 163);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(154, 20);
            this.newPass.TabIndex = 3;
            // 
            // currentPass
            // 
            this.currentPass.Location = new System.Drawing.Point(222, 128);
            this.currentPass.Name = "currentPass";
            this.currentPass.Size = new System.Drawing.Size(154, 20);
            this.currentPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comfirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Password";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(124, 249);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 33);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApply
            // 
            this.btApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApply.Location = new System.Drawing.Point(246, 249);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(91, 33);
            this.btApply.TabIndex = 10;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Change Password";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.userName);
            this.Name = "ChangePass";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox currentPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label label5;
    }
}