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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            //command.CommandText = $"insert into authors (au_id,au_fname,au_lname,address)  values('{txtId.Text}','{txtFName.Text}','{txtLName.Text}','{txtAddress.Text}')";
            command.CommandText = $"insert into authors (au_id,au_fname,au_lname,address)  values(@id,@fn,@ln,@address)";
            command.Parameters.AddWithValue("@id",txtId.Text);
            command.Parameters.AddWithValue("@fn",txtFName.Text);
            command.Parameters.AddWithValue("@ln",txtLName.Text);
            command.Parameters.AddWithValue("@address",txtAddress.Text);

            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                //container???? NOOOOOOOOO    insert
                label5.Text= $"{command.ExecuteNonQuery()} rows Affected";
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
