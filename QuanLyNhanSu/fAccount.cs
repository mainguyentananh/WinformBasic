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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
            loadDataAccount();
        }



        public void loadDataAccount()
        {
            AccountDao ac = new AccountDao();
            dataAccount.DataSource = ac.getData();
            this.dataAccount.Columns["pass"].Visible = false;
            this.dataAccount.Columns["a_id"].HeaderText = "ID";
            this.dataAccount.Columns["username"].HeaderText = "Tên đăng nhập";
            this.dataAccount.Columns["a_role"].HeaderText = "Quyền";
            this.dataAccount.Columns["fullname"].HeaderText = "Tên tài khoản";


            txbAID.DataBindings.Clear();
            txbAID.DataBindings.Add(new Binding("Text", this.dataAccount.DataSource, "a_id", true, DataSourceUpdateMode.Never));

            txbAUserName.DataBindings.Clear();
            txbAUserName.DataBindings.Add(new Binding("Text", this.dataAccount.DataSource, "username", true, DataSourceUpdateMode.Never));

            txbAFullName.DataBindings.Clear();
            txbAFullName.DataBindings.Add(new Binding("Text", this.dataAccount.DataSource, "fullname", true, DataSourceUpdateMode.Never));

            txbARole.DataBindings.Clear();
            txbARole.DataBindings.Add(new Binding("Text", this.dataAccount.DataSource, "a_role", true, DataSourceUpdateMode.Never));

        
        
        }




        private void btnACBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAAdd_Click(object sender, EventArgs e)
        {
            AccountDao ac = new AccountDao();
            string username = txbAUserName.Text;
            string pass = txbAPass.Text;
            string fullname = txbAFullName.Text;
            string role = txbARole.Text;

     
            if (ac.addAccount(username,pass,fullname,role))
             {
                MessageBox.Show("Thêm thành công");
                loadDataAccount();
             }
                else
                    MessageBox.Show("Có lỗi khi thêm");
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            AccountDao ac = new AccountDao();
            int a_id = Convert.ToInt32(txbAID.Text);
            if (ac.deleteAccount(a_id))
            {
                MessageBox.Show("Xóa thành công");
                loadDataAccount();
            }
            else
                MessageBox.Show("Có lỗi khi xóa");
        }
    }
}
