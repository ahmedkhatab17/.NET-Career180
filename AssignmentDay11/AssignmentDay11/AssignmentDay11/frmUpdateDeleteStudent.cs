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
    public partial class frmUpdateDeleteStudent : Form
    {
        public frmUpdateDeleteStudent()
        {
            InitializeComponent();
            FillStudentComboBox();
        }

        private void FillStudentComboBox()
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = "select concat(st_fname,' ',st_lname) as FullName,st_id as SSN from student";

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboStudent.DataSource = dt;
                comboStudent.DisplayMember = "FullName";
                comboStudent.ValueMember = "SSN";
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

        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Student where st_id = @id";
            command.Parameters.AddWithValue("@id", comboStudent.SelectedValue.ToString());

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                txtId.Text = dt.Rows[0]["st_id"].ToString();
                txtFName.Text = dt.Rows[0]["st_fname"].ToString();
                txtLName.Text = dt.Rows[0]["st_lname"].ToString();
                txtAdress.Text = dt.Rows[0]["st_address"].ToString();
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
        


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            command.CommandText = $"update Student set st_fname = @fn ,st_lname = @ln,st_address = @address where st_id =@id";
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.Parameters.AddWithValue("@fn", txtFName.Text);
            command.Parameters.AddWithValue("@ln", txtLName.Text);
            command.Parameters.AddWithValue("@address", txtAdress.Text);


            try
            {
                con.Open();
                result.Text = $"{command.ExecuteNonQuery()} Rows Updated";

            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure delete {txtFName.Text.ToString()}", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "delete from student where st_id=@id";
                command.Parameters.AddWithValue("@id", comboStudent.SelectedValue.ToString());


                try
                {
                    con.Open();
                    result.Text = $"{command.ExecuteNonQuery()} Rows Deleted";

                }
                catch (Exception)
                {

                    throw;
                }
                finally { con.Close(); }
            }

        }
    }
}
