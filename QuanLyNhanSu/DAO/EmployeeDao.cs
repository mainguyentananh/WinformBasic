using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class EmployeeDao
    {
        public List<Employee> getData()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Employee";
            var employee = c.Query<Employee>(sql);
            return (List<Employee>)employee;
        }


        public bool addEmployee(string name ,DateTime dob , string sex,string e_address,string idcard,string phone,int jobID, int depID)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "insert into Employee values(@name,@dob,@sex,@e_address,@idcard,@phone,@jobID,@depID)";
            var result = c.Execute(sql,new {name,dob, sex, e_address, idcard, phone,jobID,depID});
            if (result >= 1)
                return true;
            return false;
        }

        public bool editEmployee(int e_id,string name,string idcard,string sex, DateTime dob, string e_address, string phone, int jobID, int depID)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "update Employee set idcard=@idcard,sex=@sex, name=@name ,dob=@dob,e_address=@e_address,phone=@phone,jobID=@jobID,depID=@depID where e_id=@e_id";
            var result = c.Execute(sql, new { e_id,idcard,name, dob, e_address, phone, jobID, depID,sex });
            if (result >= 1)
                return true;
            return false;
        }


        public bool deleteEmployee(int e_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "delete Employee where e_id =@e_id";
            var result = c.Execute(sql, new { e_id });
            if (result >= 1)
                return true;
            return false;
        }

        public int countEmployee()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Employee";
            var result = c.Query<Employee>(sql).Count<Employee>();
            return result;
        }

    }



    public class Employee
    {
        public int e_id { get; set; }
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string e_address { get; set; }
        public string idcard { get; set; }
        public string phone { get; set; }

        public int jobID { get; set; }
        public int depID { get; set; }

    }
}
