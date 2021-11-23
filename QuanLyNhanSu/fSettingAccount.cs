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
    public partial class fSettingAccount : Form
    {
        public fSettingAccount()
        {
            InitializeComponent();
            txbSAUserName.Text = fManager.userName;
        }

        private void btnSABack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AccountDao ac = new AccountDao();

            string username = txbSAUserName.Text;
            string pass = txbSAPassword.Text;
            string npass = txbSANewPassword.Text;
            if (ac.Login(username, pass))
            {
                if (ac.changePass(username, npass))
                {
                    MessageBox.Show("Thay đổi thành công");
                    this.Hide();
                }
                else
                    MessageBox.Show("Không thể thực hiện");
            }
            else
                MessageBox.Show("Nhập sai mật khẩu");
        }
    }
}
