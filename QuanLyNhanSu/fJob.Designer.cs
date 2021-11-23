
namespace QuanLyNhanSu
{
    partial class fJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fJob));
            this.label2 = new System.Windows.Forms.Label();
            this.dataCongViec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbJID = new System.Windows.Forms.TextBox();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnJBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý công việc";
            // 
            // dataCongViec
            // 
            this.dataCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCongViec.Location = new System.Drawing.Point(96, 192);
            this.dataCongViec.Name = "dataCongViec";
            this.dataCongViec.RowHeadersWidth = 51;
            this.dataCongViec.RowTemplate.Height = 24;
            this.dataCongViec.Size = new System.Drawing.Size(501, 183);
            this.dataCongViec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Công Việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lương";
            // 
            // txbJID
            // 
            this.txbJID.Location = new System.Drawing.Point(108, 149);
            this.txbJID.Name = "txbJID";
            this.txbJID.ReadOnly = true;
            this.txbJID.Size = new System.Drawing.Size(100, 22);
            this.txbJID.TabIndex = 6;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(259, 149);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(131, 22);
            this.txbJob.TabIndex = 7;
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(442, 149);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(123, 22);
            this.txbSalary.TabIndex = 8;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(616, 328);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(120, 47);
            this.btnDeleteJob.TabIndex = 11;
            this.btnDeleteJob.Text = "Xóa";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnXoaCv_Click);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(616, 262);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(120, 47);
            this.btnEditJob.TabIndex = 12;
            this.btnEditJob.Text = "Sửa";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnSuaCv_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(616, 192);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(120, 47);
            this.btnAddJob.TabIndex = 13;
            this.btnAddJob.Text = "Thêm";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnThemCv_Click);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(QuanLyNhanSu.DAO.Job);
            // 
            // btnJBack
            // 
            this.btnJBack.Location = new System.Drawing.Point(12, 402);
            this.btnJBack.Name = "btnJBack";
            this.btnJBack.Size = new System.Drawing.Size(75, 23);
            this.btnJBack.TabIndex = 14;
            this.btnJBack.Text = "Trở lại";
            this.btnJBack.UseVisualStyleBackColor = true;
            this.btnJBack.Click += new System.EventHandler(this.btnJBack_Click);
            // 
            // fJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJBack);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.txbSalary);
            this.Controls.Add(this.txbJob);
            this.Controls.Add(this.txbJID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCongViec);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công việc";
            ((System.ComponentModel.ISupportInitialize)(this.dataCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataCongViec;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbJID;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnJBack;
    }
}