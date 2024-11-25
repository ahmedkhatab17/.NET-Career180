using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDay11
{
    public partial class frmStudentCourses : Form
    {
        public frmStudentCourses()
        {
            InitializeComponent();
            FillStudentComBox();
        }

        private void FillStudentComBox()
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            command.CommandText = "select s.St_Id, CONCAT(s.st_fname,' ',s.St_Lname) as FullName from Student s ";

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                comboxStudent.DataSource = dt;
                comboxStudent.DisplayMember = "FullName";
                comboxStudent.ValueMember = "St_Id";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void comboxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            command.CommandText = "select c.Crs_Id, c.Crs_Name, c.Crs_Duration from Stud_Course sc ,Course c where sc.crs_id =c.crs_id and sc.St_Id =@StId";
            command.Parameters.AddWithValue("@StId", comboxStudent.SelectedValue.ToString());

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                GVCourses.DataSource = dt;
                

            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }


        }
    }
}
