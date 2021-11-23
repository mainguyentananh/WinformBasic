
namespace QuanLyNhanSu
{
    partial class fDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDepartment));
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.txbDName = new System.Windows.Forms.TextBox();
            this.txbDID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataPhongBan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(600, 204);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(120, 47);
            this.btnAddDepartment.TabIndex = 23;
            this.btnAddDepartment.Text = "Thêm";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(600, 274);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(120, 47);
            this.btnEditDepartment.TabIndex = 22;
            this.btnEditDepartment.Text = "Sửa";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(600, 340);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(120, 47);
            this.btnDeleteDepartment.TabIndex = 21;
            this.btnDeleteDepartment.Text = "Xóa";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // txbDName
            // 
            this.txbDName.Location = new System.Drawing.Point(243, 161);
            this.txbDName.Name = "txbDName";
            this.txbDName.Size = new System.Drawing.Size(131, 22);
            this.txbDName.TabIndex = 19;
            // 
            // txbDID
            // 
            this.txbDID.Location = new System.Drawing.Point(92, 161);
            this.txbDID.Name = "txbDID";
            this.txbDID.ReadOnly = true;
            this.txbDID.Size = new System.Drawing.Size(100, 22);
            this.txbDID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên phòng ban";
            // 
            // dataPhongBan
            // 
            this.dataPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhongBan.Location = new System.Drawing.Point(80, 204);
            this.dataPhongBan.Name = "dataPhongBan";
            this.dataPhongBan.RowHeadersWidth = 51;
            this.dataPhongBan.RowTemplate.Height = 24;
            this.dataPhongBan.Size = new System.Drawing.Size(501, 183);
            this.dataPhongBan.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quản lý phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // btnDBack
            // 
            this.btnDBack.Location = new System.Drawing.Point(12, 405);
            this.btnDBack.Name = "btnDBack";
            this.btnDBack.Size = new System.Drawing.Size(75, 23);
            this.btnDBack.TabIndex = 25;
            this.btnDBack.Text = "Trở lại";
            this.btnDBack.UseVisualStyleBackColor = true;
            this.btnDBack.Click += new System.EventHandler(this.btnDBack_Click);
            // 
            // fDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.txbDName);
            this.Controls.Add(this.txbDID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataPhongBan);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.TextBox txbDName;
        private System.Windows.Forms.TextBox txbDID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDBack;
    }
}