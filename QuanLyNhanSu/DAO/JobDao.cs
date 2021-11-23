using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class JobDao
    {
        public List<Job> getData()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Job";
            var job = c.Query<Job>(sql);
            return (List<Job>)job;
        }


        public bool addJob(string name, string base_salary)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "insert into Job values(@name,@base_salary)";
            int result = c.Execute(sql,new { name , base_salary });
            if (result >= 1)
                return true;
            return false;
        }

        public bool editJob(int j_id,string name, string base_salary)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "update Job set name=@name, base_salary=@base_salary where j_id = @j_id";
            int result = c.Execute(sql, new { j_id,name, base_salary });
            if (result >= 1)
                return true;
            return false;
        }

        public bool deleteJob(int j_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "delete Job where j_id = @j_id";
            int result = c.Execute(sql, new { j_id});
            if (result >= 1)
                return true;
            return false;
        }

    
        public Job getJobById(int j_id)
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Job where j_id = @j_id";
            var job = c.Query<Job>(sql, new { j_id }).ToList().FirstOrDefault<Job>();
            return job;
        }


        public int countJob()
        {
            string connect = "Server=.\\SQLEXPRESS;Database=quanlynhansu;Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connect);
            string sql = "select * from Job";
            var job = c.Query<Job>(sql).Count<Job>();
            return job;
        }



    }


    public class Job
    {
        public int j_id { get; set; }
        public string name { get; set; }
        public float base_salary { get; set; }
    }
}
