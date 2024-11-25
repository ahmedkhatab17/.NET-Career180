using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AssignmentDay11
{
    public partial class frmSelectAllStudent : Form
    {
        public frmSelectAllStudent()
        {
            InitializeComponent();
            DisplayAllStudents();
        }

        private void DisplayAllStudents()
        {
            SqlConnection connection = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Student";
            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                
                grindAllStudents.DataSource = dataTable;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
