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

namespace ADOConnectedMode
{
    public partial class frmUpdateAndDelete : Form
    {
        public frmUpdateAndDelete()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }

        private void FillAuthorsToComboBox()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = "select concat(au_fname,' ',au_lname) as FullName,au_id as SSN from authors";

            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboAuthors.DataSource = dt;
                comboAuthors.DisplayMember = "FullName";
                comboAuthors.ValueMember = "SSN";
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

        private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from authors where au_id=@id";
            command.Parameters.AddWithValue("@id", comboAuthors.SelectedValue.ToString());

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                ////dt.rows.count  1
                ///dt.rows[0][0]  //id->reda
                ///dt.Rows[0][1]  //au_lname
                ///dt.Rows[0]["au_fname"] 
                txtId.Text = dt.Rows[0]["au_id"].ToString();
                txtFName.Text = dt.Rows[0]["au_fname"].ToString();
                txtLName.Text = dt.Rows[0]["au_lname"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtId.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "update authors set au_fname=@fn,au_lname=@ln,address=@address where au_id=@id";
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.Parameters.AddWithValue("@fn", txtFName.Text);
            command.Parameters.AddWithValue("@ln", txtLName.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);

            command.Connection = con;
            try
            {
                con.Open();
                lblResult.Text = $"{command.ExecuteNonQuery()} Rows Affected";
                //int affected=command.ExecuteNonQuery();
                //if (affected > 0) {
                FillAuthorsToComboBox();
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
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");

                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from authors where au_id=@id";
                command.Parameters.AddWithValue("@id", comboAuthors.SelectedValue.ToString());

                command.Connection = con;
                try
                {
                    con.Open();
                    lblResult.Text = $"{command.ExecuteNonQuery()} Rows Deleted";
                    FillAuthorsToComboBox(); //refresh
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

///Lab Assignments
///Any Table
///form select all students
///form choose student and get its courses
///form insert student
///form update and delete student

