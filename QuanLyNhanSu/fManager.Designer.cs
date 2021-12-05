
namespace QuanLyNhanSu
{
    partial class fManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettingAccount = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAccount = new System.Windows.Forms.Label();
            this.nameAccount = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(17, 13);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(164, 34);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Quản lý nhân viên";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnDanhSachNv_Click);
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(210, 13);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(157, 34);
            this.btnJob.TabIndex = 4;
            this.btnJob.Text = "Quản lý công việc";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnCongViec_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(210, 67);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(169, 37);
            this.btnDepartment.TabIndex = 5;
            this.btnDepartment.Text = "Quản lý phòng ban";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnDepartment);
            this.panel1.Controls.Add(this.btnJob);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Location = new System.Drawing.Point(94, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 117);
            this.panel1.TabIndex = 6;
            // 
            // btnSettingAccount
            // 
            this.btnSettingAccount.Location = new System.Drawing.Point(25, 47);
            this.btnSettingAccount.Name = "btnSettingAccount";
            this.btnSettingAccount.Size = new System.Drawing.Size(154, 30);
            this.btnSettingAccount.TabIndex = 9;
            this.btnSettingAccount.Text = "Thiết lập tài khoản";
            this.btnSettingAccount.UseVisualStyleBackColor = true;
            this.btnSettingAccount.Click += new System.EventHandler(this.btnSettingAccount_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(405, 67);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(157, 37);
            this.btnContact.TabIndex = 7;
            this.btnContact.Text = "Liên hệ";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(405, 13);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(157, 34);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(209, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 30);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Xin chào:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSettingAccount);
            this.panel2.Controls.Add(this.lbAccount);
            this.panel2.Controls.Add(this.nameAccount);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(203, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 109);
            this.panel2.TabIndex = 10;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.Location = new System.Drawing.Point(206, 15);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(47, 17);
            this.lbAccount.TabIndex = 11;
            this.lbAccount.Text = "label3";
            // 
            // nameAccount
            // 
            this.nameAccount.AutoSize = true;
            this.nameAccount.Location = new System.Drawing.Point(112, 8);
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.Size = new System.Drawing.Size(0, 17);
            this.nameAccount.TabIndex = 10;
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(17, 67);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(164, 37);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.Text = "Quản lý tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataSource = typeof(QuanLyNhanSu.DAO.Account);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(QuanLyNhanSu.DAO.Account);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettingAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameAccount;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Button btnAccount;
    }
}