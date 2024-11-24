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
    public partial class frmSelectV2 : Form
    {
        public frmSelectV2()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }

        private void FillAuthorsToComboBox()
        {
            string constr = "Server=DESKTOP-MFABGAV;Database=pubs;Trusted_connection=true;TrustServerCertificate=true";
            SqlConnection con = new SqlConnection(constr);

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Authors";

            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                comboAuthors.DataSource = dt;
                //
                comboAuthors.DisplayMember = "au_fname";
                comboAuthors.ValueMember = "au_id";
                //
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

        //eventHandler
        //start without debugging [runtime purpose]
        private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-MFABGAV;Database=pubs;Trusted_connection=true;TrustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            var id = comboAuthors.SelectedValue.ToString();
            //command.CommandText = $"select t.* from authors a,titles t,titleauthor ta where a.au_id=ta.au_id and ta.title_id=t.title_id and a.au_id='{id}'";
            command.CommandText = $"select t.* from authors a,titles t,titleauthor ta where a.au_id=ta.au_id and ta.title_id=t.title_id and a.au_id=@Mr";
            command.Parameters.AddWithValue("@Mr", id);
            command.Connection = con;
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridTitles.DataSource = dt;
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
