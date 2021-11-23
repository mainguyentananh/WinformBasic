using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class fJob : Form
    {
        public fJob()
        {
            InitializeComponent();
            loadDataJob();

        }

        public void loadDataJob()
        {
            JobDao j = new JobDao();
            dataCongViec.DataSource = j.getData();
            this.dataCongViec.Columns["j_id"].HeaderText = "ID";
            this.dataCongViec.Columns["name"].HeaderText = "Công Việc";
            this.dataCongViec.Columns["base_salary"].HeaderText = "Lương";

            txbJID.DataBindings.Clear();
            txbJID.DataBindings.Add(new Binding("Text", this.dataCongViec.DataSource, "j_id",true,DataSourceUpdateMode.Never));

            txbJob.DataBindings.Clear();
            txbJob.DataBindings.Add(new Binding("Text", this.dataCongViec.DataSource, "name",true, DataSourceUpdateMode.Never));

            txbSalary.DataBindings.Clear();
            txbSalary.DataBindings.Add(new Binding("Text", this.dataCongViec.DataSource, "base_salary",true, DataSourceUpdateMode.Never));
        }

        private void btnThemCv_Click(object sender, EventArgs e)
        {
            JobDao j = new JobDao();
            string name = txbJob.Text;
            string base_salary = txbSalary.Text;
            if (j.addJob(name,base_salary))
            {      
                MessageBox.Show("Thêm thành công");
                loadDataJob();
            }
            else 
                MessageBox.Show("Có lỗi khi thêm");
        }

        private void btnSuaCv_Click(object sender, EventArgs e)
        {
            JobDao j = new JobDao();
            int j_id = Convert.ToInt32(txbJID.Text);
            string name = txbJob.Text;
            string base_salary = txbSalary.Text;
            if (j.editJob(j_id,name, base_salary))
            {
                MessageBox.Show("Sửa thành công");
                loadDataJob();
            }
            else
                MessageBox.Show("Có lỗi khi sửa");

        }

        private void btnXoaCv_Click(object sender, EventArgs e)
        {
            JobDao j = new JobDao();
            int j_id = Convert.ToInt32(txbJID.Text);
            if (j.deleteJob(j_id))
            {
                MessageBox.Show("Xóa thành công");
                loadDataJob();
            }
            else
                MessageBox.Show("Có lỗi khi xóa");
        }

        private void btnJBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
