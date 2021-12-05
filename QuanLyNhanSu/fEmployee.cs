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
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
            loadDataEmployee();
        }

        public void loadDataEmployee()
        {
            EmployeeDao edao = new EmployeeDao();
            dataNhanVien.DataSource = edao.getData();

            JobDao jdao = new JobDao();
            cbEJob.DataSource = jdao.getData();
            cbEJob.DisplayMember = "name";
            cbEJob.ValueMember = "j_id";

            DepartmentDao ddao = new DepartmentDao();
            cbEDepartment.DataSource = ddao.getData();
            cbEDepartment.DisplayMember = "name";
            cbEDepartment.ValueMember = "d_id";

            txbESalary.DataBindings.Clear();
            txbESalary.DataBindings.Add(new Binding("Text", this.cbEJob.DataSource, "base_salary", true, DataSourceUpdateMode.Never));

            this.dataNhanVien.Columns["e_id"].HeaderText = "ID";
            this.dataNhanVien.Columns["name"].HeaderText = "Họ Tên";
            this.dataNhanVien.Columns["dob"].HeaderText = "Ngày Sinh";
            this.dataNhanVien.Columns["e_address"].HeaderText = "Địa Chỉ";
            this.dataNhanVien.Columns["idcard"].HeaderText = "Căn cước công dân";
            this.dataNhanVien.Columns["sex"].HeaderText = "Giới tính";
            this.dataNhanVien.Columns["phone"].HeaderText = "Số Điện Thoại";
            this.dataNhanVien.Columns["jobID"].HeaderText = "ID Công Việc";
            this.dataNhanVien.Columns["depID"].HeaderText = "ID Phòng Ban";

            txbEID.DataBindings.Clear();
            txbEID.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "e_id", true, DataSourceUpdateMode.Never));

            txbEName.DataBindings.Clear();
            txbEName.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "name", true, DataSourceUpdateMode.Never));

            dtpE.DataBindings.Clear();
            dtpE.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "dob", true, DataSourceUpdateMode.Never));

            txbEPhone.DataBindings.Clear();
            txbEPhone.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "phone", true, DataSourceUpdateMode.Never));

            txbESex.DataBindings.Clear();
            txbESex.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "sex", true, DataSourceUpdateMode.Never));


            txbEIDCard.DataBindings.Clear();
            txbEIDCard.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "idcard", true, DataSourceUpdateMode.Never));


            txbEAddress.DataBindings.Clear();
            txbEAddress.DataBindings.Add(new Binding("Text", this.dataNhanVien.DataSource, "e_address", true, DataSourceUpdateMode.Never));


        }

        private void btnEBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void txbEID_TextChanged(object sender, EventArgs e)
        {
            if (dataNhanVien.SelectedCells.Count > 0)
            {

                //Cb Job
                JobDao jdao = new JobDao();

                int j_id = (int)dataNhanVien.SelectedCells[0].OwningRow.Cells["jobID"].Value;
                Job job = jdao.getJobById(j_id);
                cbEJob.SelectedItem = job;
                int j_index = -1;
                int i = 0;
                foreach (Job item in cbEJob.Items)
                {
                    if (item.j_id == job.j_id)
                    {
                        j_index = i;
                        break;
                    }
                    i++;
                }
                cbEJob.SelectedIndex = j_index;

                //Cb Department
                DepartmentDao ddao = new DepartmentDao();
                int d_id = (int)dataNhanVien.SelectedCells[0].OwningRow.Cells["depID"].Value;
                Department dep = ddao.getDepartmentByID(d_id);
                cbEDepartment.SelectedItem = dep;

                int d_index = -1;
                int j = 0;
                foreach (Department item in cbEDepartment.Items)
                {
                    if (item.d_id == dep.d_id)
                    {
                        d_index = j;
                        break;
                    }
                    j++;
                }
                cbEDepartment.SelectedIndex = d_index;

            }

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            EmployeeDao edao = new EmployeeDao();

            string name = txbEName.Text;
            DateTime dob = dtpE.Value;
            string e_address = txbEAddress.Text;
            string phone = txbEPhone.Text;
            string sex = txbESex.Text;
            string idcard = txbEIDCard.Text;
            int jobid = (cbEJob.SelectedItem as Job).j_id;
            int depid = (cbEDepartment.SelectedItem as Department).d_id;
            
            if (edao.addEmployee(name,dob, sex, e_address, idcard,phone,jobid,depid))
            {
                
                MessageBox.Show("Thêm thành công");
                loadDataEmployee();
            }
            else
                MessageBox.Show("Có lỗi khi thêm");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            EmployeeDao edao = new EmployeeDao();
            int e_id = Convert.ToInt32(txbEID.Text);
            string name = txbEName.Text;
            DateTime dob = dtpE.Value;
            string e_address = txbEAddress.Text;
            string phone = txbEPhone.Text;
            int jobid = (cbEJob.SelectedItem as Job).j_id;
            int depid = (cbEDepartment.SelectedItem as Department).d_id;
            string sex = txbESex.Text;
            string idcard = txbEIDCard.Text;
            if (edao.editEmployee(e_id,name,idcard,sex, dob, e_address, phone, jobid, depid))
            {

                MessageBox.Show("Sửa thành công");
                loadDataEmployee();
            }
            else
                MessageBox.Show("Có lỗi khi sửa");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            EmployeeDao edao = new EmployeeDao();
            int e_id = Convert.ToInt32(txbEID.Text);
            if (edao.deleteEmployee(e_id))
            {

                MessageBox.Show("Xóa thành công");
                loadDataEmployee();
            }
            else
                MessageBox.Show("Có lỗi khi xóa");
        }
    }
}
