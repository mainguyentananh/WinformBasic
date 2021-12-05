using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace QuanLyNhanSu.DAO
{
    public class AccountDao
    {


        public List<Account> getData()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select a_id,username,fullname,a_role from Account";
            var account = c.Query<Account>(sql);
            return (List<Account>)account;
        }


        public bool addAccount(string username, string pass, string fullname, string role)
        {
        
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "insert into Account values(@username,@pass,@fullname,@role)";
            int result = c.Execute(sql, new { username, pass, fullname , role });
            if (result >= 1)
                return true;
            return false;
        }

        public bool deleteAccount(int a_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "delete Account where a_id = @a_id";
            int result = c.Execute(sql, new { a_id });
            if (result >= 1)
                return true;
            return false;
        }

        public bool Login(string username,string pass)
        {

            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Account where username like @username and pass like @pass";
            var account = c.Query<Account>(sql,new { username, pass });
            int a = account.ToList().Count();
            if (a > 0)
                return true;

            return false;
        }

        
        public bool changePass(string username, string npass)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "update Account set pass = @npass where username like @username";
            var result = c.Execute(sql, new {npass,username});
            if (result >= 1)
                return true;

            return false;
        }


        public Account getAccount(string username, string pass)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Account where username = @username and pass = @pass";
            var ac = c.Query<Account>(sql, new { username, pass }).ToList().FirstOrDefault<Account>();
            return ac;
        }

    }

    public class Account
    {
        public int a_id { get; set; }
        public  string username { get; set; }
        public string pass { get; set; }

        public string fullname { get; set; }
        public string a_role { get; set; }

       

    }
}
