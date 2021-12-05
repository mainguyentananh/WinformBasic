
namespace QuanLyNhanSu
{
    partial class fAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.btnACBack = new System.Windows.Forms.Button();
            this.btnAAdd = new System.Windows.Forms.Button();
            this.btnADelete = new System.Windows.Forms.Button();
            this.txbAFullName = new System.Windows.Forms.TextBox();
            this.txbAUserName = new System.Windows.Forms.TextBox();
            this.txbAID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.txbARole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý tài khoản";
            // 
            // btnACBack
            // 
            this.btnACBack.Location = new System.Drawing.Point(27, 403);
            this.btnACBack.Name = "btnACBack";
            this.btnACBack.Size = new System.Drawing.Size(75, 23);
            this.btnACBack.TabIndex = 15;
            this.btnACBack.Text = "Trở lại";
            this.btnACBack.UseVisualStyleBackColor = true;
            this.btnACBack.Click += new System.EventHandler(this.btnACBack_Click);
            // 
            // btnAAdd
            // 
            this.btnAAdd.Location = new System.Drawing.Point(740, 200);
            this.btnAAdd.Name = "btnAAdd";
            this.btnAAdd.Size = new System.Drawing.Size(120, 47);
            this.btnAAdd.TabIndex = 25;
            this.btnAAdd.Text = "Thêm";
            this.btnAAdd.UseVisualStyleBackColor = true;
            this.btnAAdd.Click += new System.EventHandler(this.btnAAdd_Click);
            // 
            // btnADelete
            // 
            this.btnADelete.Location = new System.Drawing.Point(740, 267);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(120, 47);
            this.btnADelete.TabIndex = 23;
            this.btnADelete.Text = "Xóa";
            this.btnADelete.UseVisualStyleBackColor = true;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // txbAFullName
            // 
            this.txbAFullName.Location = new System.Drawing.Point(418, 114);
            this.txbAFullName.Name = "txbAFullName";
            this.txbAFullName.Size = new System.Drawing.Size(123, 22);
            this.txbAFullName.TabIndex = 22;
            // 
            // txbAUserName
            // 
            this.txbAUserName.Location = new System.Drawing.Point(235, 114);
            this.txbAUserName.Name = "txbAUserName";
            this.txbAUserName.Size = new System.Drawing.Size(131, 22);
            this.txbAUserName.TabIndex = 21;
            // 
            // txbAID
            // 
            this.txbAID.Location = new System.Drawing.Point(84, 114);
            this.txbAID.Name = "txbAID";
            this.txbAID.ReadOnly = true;
            this.txbAID.Size = new System.Drawing.Size(100, 22);
            this.txbAID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // dataAccount
            // 
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(80, 200);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.RowHeadersWidth = 51;
            this.dataAccount.RowTemplate.Height = 24;
            this.dataAccount.Size = new System.Drawing.Size(632, 183);
            this.dataAccount.TabIndex = 16;
            // 
            // txbARole
            // 
            this.txbARole.Location = new System.Drawing.Point(589, 114);
            this.txbARole.Name = "txbARole";
            this.txbARole.Size = new System.Drawing.Size(123, 22);
            this.txbARole.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mật khẩu";
            // 
            // txbAPass
            // 
            this.txbAPass.Location = new System.Drawing.Point(740, 114);
            this.txbAPass.Name = "txbAPass";
            this.txbAPass.Size = new System.Drawing.Size(123, 22);
            this.txbAPass.TabIndex = 28;
            this.txbAPass.UseSystemPasswordChar = true;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbAPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbARole);
            this.Controls.Add(this.btnAAdd);
            this.Controls.Add(this.btnADelete);
            this.Controls.Add(this.txbAFullName);
            this.Controls.Add(this.txbAUserName);
            this.Controls.Add(this.txbAID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAccount);
            this.Controls.Add(this.btnACBack);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnACBack;
        private System.Windows.Forms.Button btnAAdd;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.TextBox txbAFullName;
        private System.Windows.Forms.TextBox txbAUserName;
        private System.Windows.Forms.TextBox txbAID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.TextBox txbARole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAPass;
    }
}