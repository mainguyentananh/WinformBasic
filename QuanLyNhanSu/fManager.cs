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
    public partial class fManager : Form
    {
        public static string userName;
       
        public fManager()
        {
            InitializeComponent();
            lbAccount.Text = userName;
        }

        

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            fJob j = new fJob();
            j.ShowDialog();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            fDepartment d = new fDepartment();
            d.ShowDialog();
        }

        private void btnDanhSachNv_Click(object sender, EventArgs e)
        {
            fEmployee ep = new fEmployee();
            ep.ShowDialog();
        }

        private void btnSettingAccount_Click(object sender, EventArgs e)
        {
            fSettingAccount sa = new fSettingAccount();
            sa.ShowDialog();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            fContact contact = new fContact();
            contact.ShowDialog();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            fStatistic statistic = new fStatistic();
            statistic.ShowDialog();
        }
    }
}
