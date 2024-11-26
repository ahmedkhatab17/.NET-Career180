using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusinessLayer
{
    public class StudentBusinessLayer
    {
        public static DataTable GetAll()
        {
            string query = "select * from student";
            return SchoolDBManage.DataAccessLayer.ExecuteQuery(query);
        }
        public static DataTable GetOne(string id)
        {
            var query = $"select * from student where st_id='{id}'";
            return SchoolDBManage.DataAccessLayer.ExecuteQuery(query);
        }
        public static int Add(Student a1)
        {
            var query = "insert into student (st_id,st_fname,st_lname,st_address) values(@id,@fn,@ln,@address)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",a1.St_id),
                new SqlParameter("@fn",a1.St_fname),
                new SqlParameter("@ln",a1.St_lname),
                new SqlParameter("@address",a1.St_Address)
            };
            return SchoolDBManage.DataAccessLayer.ExecuteNonQuery(query, parameters);
        }
        public static int Update(Student a1)
        {
            var query = "update student set st_fname=@fn,st_lname=@ln,st_address=@address where st_id=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",a1.St_id),
                new SqlParameter("@fn",a1.St_fname),
                new SqlParameter("@ln",a1.St_lname),
                new SqlParameter("@address",a1.St_Address)
            };
            return SchoolDBManage.DataAccessLayer.ExecuteNonQuery(query, parameters);
        }
        public static int Delete(string id)
        {
            var query = "delete from student where st_id=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            return SchoolDBManage.DataAccessLayer.ExecuteNonQuery(query, parameters);
        }
    }
}
