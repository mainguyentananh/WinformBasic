
namespace QuanLyNhanSu
{
    partial class fStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistic));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCountDepartment = new System.Windows.Forms.Label();
            this.lbCountJob = new System.Windows.Forms.Label();
            this.lbCountEmployee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // btnSBack
            // 
            this.btnSBack.Location = new System.Drawing.Point(33, 371);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(75, 23);
            this.btnSBack.TabIndex = 1;
            this.btnSBack.Text = "Trở lại";
            this.btnSBack.UseVisualStyleBackColor = true;
            this.btnSBack.Click += new System.EventHandler(this.btnSBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCountDepartment);
            this.panel1.Controls.Add(this.lbCountJob);
            this.panel1.Controls.Add(this.lbCountEmployee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(193, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 166);
            this.panel1.TabIndex = 2;
            // 
            // lbCountDepartment
            // 
            this.lbCountDepartment.AutoSize = true;
            this.lbCountDepartment.Location = new System.Drawing.Point(192, 119);
            this.lbCountDepartment.Name = "lbCountDepartment";
            this.lbCountDepartment.Size = new System.Drawing.Size(46, 17);
            this.lbCountDepartment.TabIndex = 5;
            this.lbCountDepartment.Text = "label5";
            // 
            // lbCountJob
            // 
            this.lbCountJob.AutoSize = true;
            this.lbCountJob.Location = new System.Drawing.Point(192, 80);
            this.lbCountJob.Name = "lbCountJob";
            this.lbCountJob.Size = new System.Drawing.Size(46, 17);
            this.lbCountJob.TabIndex = 4;
            this.lbCountJob.Text = "label5";
            // 
            // lbCountEmployee
            // 
            this.lbCountEmployee.AutoSize = true;
            this.lbCountEmployee.Location = new System.Drawing.Point(192, 40);
            this.lbCountEmployee.Name = "lbCountEmployee";
            this.lbCountEmployee.Size = new System.Drawing.Size(46, 17);
            this.lbCountEmployee.TabIndex = 3;
            this.lbCountEmployee.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số phòng ban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số nhân viên:";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSBack);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountEmployee;
        private System.Windows.Forms.Label lbCountDepartment;
        private System.Windows.Forms.Label lbCountJob;
    }
}