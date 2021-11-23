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


    }

    public class Account
    {
        public  string username { get; set; }
        public string pass { get; set; }

    }
}
