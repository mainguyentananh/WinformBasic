
namespace QuanLyNhanSu
{
    partial class fEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
            this.btnEBack = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.txbEName = new System.Windows.Forms.TextBox();
            this.txbEID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEPhone = new System.Windows.Forms.TextBox();
            this.txbEAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbESalary = new System.Windows.Forms.TextBox();
            this.cbEJob = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.cbEDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEBack
            // 
            this.btnEBack.Location = new System.Drawing.Point(12, 415);
            this.btnEBack.Name = "btnEBack";
            this.btnEBack.Size = new System.Drawing.Size(75, 23);
            this.btnEBack.TabIndex = 26;
            this.btnEBack.Text = "Trở lại";
            this.btnEBack.UseVisualStyleBackColor = true;
            this.btnEBack.Click += new System.EventHandler(this.btnEBack_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(609, 240);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 47);
            this.btnAddEmployee.TabIndex = 25;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(609, 302);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(120, 47);
            this.btnEditEmployee.TabIndex = 24;
            this.btnEditEmployee.Text = "Sửa";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(609, 355);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(120, 47);
            this.btnDeleteEmployee.TabIndex = 23;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // txbEName
            // 
            this.txbEName.Location = new System.Drawing.Point(178, 121);
            this.txbEName.Name = "txbEName";
            this.txbEName.Size = new System.Drawing.Size(164, 22);
            this.txbEName.TabIndex = 21;
            // 
            // txbEID
            // 
            this.txbEID.Location = new System.Drawing.Point(24, 121);
            this.txbEID.Name = "txbEID";
            this.txbEID.ReadOnly = true;
            this.txbEID.Size = new System.Drawing.Size(100, 22);
            this.txbEID.TabIndex = 20;
            this.txbEID.TextChanged += new System.EventHandler(this.txbEID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Location = new System.Drawing.Point(24, 236);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.RowTemplate.Height = 24;
            this.dataNhanVien.Size = new System.Drawing.Size(563, 173);
            this.dataNhanVien.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quản lý nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số điện thoại";
            // 
            // txbEPhone
            // 
            this.txbEPhone.Location = new System.Drawing.Point(576, 121);
            this.txbEPhone.Name = "txbEPhone";
            this.txbEPhone.Size = new System.Drawing.Size(123, 22);
            this.txbEPhone.TabIndex = 28;
            // 
            // txbEAddress
            // 
            this.txbEAddress.Location = new System.Drawing.Point(24, 184);
            this.txbEAddress.Name = "txbEAddress";
            this.txbEAddress.Size = new System.Drawing.Size(138, 22);
            this.txbEAddress.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Lương";
            // 
            // txbESalary
            // 
            this.txbESalary.Location = new System.Drawing.Point(576, 184);
            this.txbESalary.Name = "txbESalary";
            this.txbESalary.ReadOnly = true;
            this.txbESalary.Size = new System.Drawing.Size(123, 22);
            this.txbESalary.TabIndex = 32;
            // 
            // cbEJob
            // 
            this.cbEJob.FormattingEnabled = true;
            this.cbEJob.Location = new System.Drawing.Point(195, 182);
            this.cbEJob.Name = "cbEJob";
            this.cbEJob.Size = new System.Drawing.Size(158, 24);
            this.cbEJob.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Công việc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Phòng ban";
            // 
            // dtpE
            // 
            this.dtpE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpE.Location = new System.Drawing.Point(392, 121);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(150, 22);
            this.dtpE.TabIndex = 37;
            // 
            // cbEDepartment
            // 
            this.cbEDepartment.FormattingEnabled = true;
            this.cbEDepartment.Location = new System.Drawing.Point(392, 182);
            this.cbEDepartment.Name = "cbEDepartment";
            this.cbEDepartment.Size = new System.Drawing.Size(158, 24);
            this.cbEDepartment.TabIndex = 38;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEDepartment);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEJob);
            this.Controls.Add(this.txbESalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEBack);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.txbEName);
            this.Controls.Add(this.txbEID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataNhanVien);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEBack;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox txbEName;
        private System.Windows.Forms.TextBox txbEID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEPhone;
        private System.Windows.Forms.TextBox txbEAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbESalary;
        private System.Windows.Forms.ComboBox cbEJob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.ComboBox cbEDepartment;
    }
}