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
    public partial class fDepartment : Form
    {
        public fDepartment()
        {
            InitializeComponent();
            loadDatDepartment();
        }

        public void loadDatDepartment()
        {
            DepartmentDao d = new DepartmentDao();
            dataPhongBan.DataSource = d.getData();
            this.dataPhongBan.Columns["d_id"].HeaderText = "ID";
            this.dataPhongBan.Columns["name"].HeaderText = "Tên Phòng";

            txbDID.DataBindings.Clear();
            txbDID.DataBindings.Add(new Binding("Text", this.dataPhongBan.DataSource, "d_id", true, DataSourceUpdateMode.Never));

            txbDName.DataBindings.Clear();
            txbDName.DataBindings.Add(new Binding("Text", this.dataPhongBan.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            DepartmentDao d = new DepartmentDao();
            string name = txbDName.Text;
            if (d.addDepertment(name))
            {
                MessageBox.Show("Thêm thành công");
                loadDatDepartment();
            }
            else
                MessageBox.Show("Có lỗi khi thêm");
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            DepartmentDao d = new DepartmentDao();
            string name = txbDName.Text;
            int d_id = Convert.ToInt32(txbDID.Text);
            if (d.editDepertment(d_id,name))
            {
                MessageBox.Show("Sửa thành công");
                loadDatDepartment();
            }
            else
                MessageBox.Show("Có lỗi khi sửa");
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            DepartmentDao d = new DepartmentDao();
            int d_id = Convert.ToInt32(txbDID.Text);
            if (d.deleteDepertment(d_id))
            {
                MessageBox.Show("Xóa thành công");
                loadDatDepartment();
            }
            else
                MessageBox.Show("Có lỗi khi xóa");
        }

        private void btnDBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
