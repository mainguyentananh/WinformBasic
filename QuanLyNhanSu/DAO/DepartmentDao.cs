using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DepartmentDao
    {
        public List<Department> getData()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Department";
            var department = c.Query<Department>(sql);
            return (List<Department>)department;
        }



        public bool addDepertment(string name)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "insert into Department values(@name)";
            var result = c.Execute(sql, new { name });
            if (result >= 1)
                return true;
            return false;
        }

        public bool editDepertment(int d_id, string name)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "update Department set name=@name where d_id = @d_id";
            var result = c.Execute(sql, new { d_id,name });
            if (result >= 1)
                return true;
            return false;
        }


        public bool deleteDepertment(int d_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "delete Department where d_id = @d_id";
            int result = c.Execute(sql, new { d_id });
            if (result >= 1)
                return true;
            return false;
        }


        public Department getDepartmentByID(int d_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Department where d_id = @d_id";
            var department = c.Query<Department>(sql, new { d_id }).ToList().FirstOrDefault<Department>();
            return department;
        }


        public int countDepartment()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Department";
            var department = c.Query<Department>(sql).Count<Department>();
            return department;
        }


    }


    public class Department
    {
        public int d_id { get; set; }
        public string name { get; set; }
    }
}
