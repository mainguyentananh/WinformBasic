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
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();

            EmployeeDao edao = new EmployeeDao();
            lbCountEmployee.Text = edao.countEmployee().ToString();

            DepartmentDao ddao = new DepartmentDao();
            lbCountDepartment.Text = ddao.countDepartment().ToString();

            JobDao jdao = new JobDao();
            lbCountJob.Text = jdao.countJob().ToString();

        }

        private void btnSBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
