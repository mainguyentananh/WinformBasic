
namespace QuanLyNhanSu
{
    partial class fSettingAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettingAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSANewPassword = new System.Windows.Forms.TextBox();
            this.txbSAPassword = new System.Windows.Forms.TextBox();
            this.txbSAUserName = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSABack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đổi mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSANewPassword);
            this.panel1.Controls.Add(this.txbSAPassword);
            this.panel1.Controls.Add(this.txbSAUserName);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 216);
            this.panel1.TabIndex = 2;
            // 
            // txbSANewPassword
            // 
            this.txbSANewPassword.Location = new System.Drawing.Point(153, 120);
            this.txbSANewPassword.Name = "txbSANewPassword";
            this.txbSANewPassword.Size = new System.Drawing.Size(187, 22);
            this.txbSANewPassword.TabIndex = 6;
            this.txbSANewPassword.UseSystemPasswordChar = true;
            // 
            // txbSAPassword
            // 
            this.txbSAPassword.Location = new System.Drawing.Point(153, 78);
            this.txbSAPassword.Name = "txbSAPassword";
            this.txbSAPassword.Size = new System.Drawing.Size(187, 22);
            this.txbSAPassword.TabIndex = 5;
            this.txbSAPassword.UseSystemPasswordChar = true;
            // 
            // txbSAUserName
            // 
            this.txbSAUserName.Location = new System.Drawing.Point(153, 33);
            this.txbSAUserName.Name = "txbSAUserName";
            this.txbSAUserName.ReadOnly = true;
            this.txbSAUserName.Size = new System.Drawing.Size(187, 22);
            this.txbSAUserName.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(224, 166);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(116, 34);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Tiến hành";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnSABack
            // 
            this.btnSABack.Location = new System.Drawing.Point(26, 387);
            this.btnSABack.Name = "btnSABack";
            this.btnSABack.Size = new System.Drawing.Size(103, 30);
            this.btnSABack.TabIndex = 4;
            this.btnSABack.Text = "Trở lại";
            this.btnSABack.UseVisualStyleBackColor = true;
            this.btnSABack.Click += new System.EventHandler(this.btnSABack_Click);
            // 
            // fSettingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSABack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettingAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSANewPassword;
        private System.Windows.Forms.TextBox txbSAPassword;
        private System.Windows.Forms.TextBox txbSAUserName;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSABack;
    }
}