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
    public partial class frmInsertStudent : Form
    {
        public frmInsertStudent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into Student (st_id,st_fname,st_lname,st_address)  values(@id,@fn,@ln,@address)";
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.Parameters.AddWithValue("@fn", txtFName.Text);
            command.Parameters.AddWithValue("@ln", txtLName.Text);
            command.Parameters.AddWithValue("@address", txtAdress.Text);

            
            command.Connection = con;

            try
            {
                con.Open();
                result.Text = $"{command.ExecuteNonQuery()} rows Inserted";
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
    }
}
