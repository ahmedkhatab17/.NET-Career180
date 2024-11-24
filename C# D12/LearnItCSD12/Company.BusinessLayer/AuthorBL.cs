using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLayer
{
    public class AuthorBL
    {
        public static DataTable GetAll()
        {
            string query = "select * from authors";
            return Company.DBManager.DataAccessLayer.ExecuteQuery(query);
        }
        public static DataTable GetOne(string id)
        {
            var query = $"select * from authors where au_id='{id}'";
            return Company.DBManager.DataAccessLayer.ExecuteQuery(query);
        }
        public static int Add(Author a1)
        {
            var query = "insert into authors (au_id,au_fname,au_lname,address) values(@id,@fn,@ln,@address)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",a1.Au_id),
                new SqlParameter("@fn",a1.Au_fname),
                new SqlParameter("@ln",a1.Au_lname),
                new SqlParameter("@address",a1.Address)
            };
            return Company.DBManager.DataAccessLayer.ExecuteNonQuery(query, parameters);
        }
        public static int Update(Author a1)
        {
            var query = "update authors set au_fname=@fn,au_lname=@ln,address=@address where au_id=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",a1.Au_id),
                new SqlParameter("@fn",a1.Au_fname),
                new SqlParameter("@ln",a1.Au_lname),
                new SqlParameter("@address",a1.Address)
            };
            return Company.DBManager.DataAccessLayer.ExecuteNonQuery(query,parameters);
        }
        public static int  Delete(string id) 
        {
            var query = "delete from authors where au_id=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            return Company.DBManager.DataAccessLayer.ExecuteNonQuery (query, parameters);
        }
    }

    /////////
    //interface IMyService<T>
    //{
    //    int Add(T entity);
    //    int Update(T entity);
    //    T GetOne(int id);
    //    List<T> GetAll();
    //}

    //class EmployeeService : IMyService<Employee>
    //{
    //    public int Add(Employee entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Employee> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Employee GetOne(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Update(Employee entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class CompanyService<T> : IMyService<T>
    //{
    //    public int Add(T entity)
    //    {
    //        //insert into authors values ......
    //    }

    //    public List<T> GetAll()
    //    {
    //        //select * from authors
    //    }

    //    public T GetOne(int id)
    //    {
    //        //select * from authors where id=id
    //    }

    //    public int Update(T entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    ///////////
    /////object CompanyService<Author> c1=new CompanyService<Author>
    /////object CompanyService<Employee> c1=new CompanyService<Employee>
}

///Lab Assignments
///
////1- use yesterday example as a disconnected mode

////2- convert previous example as a LAyers
////data access layer
////business layer
////presentation layer