using Microsoft.Data.SqlClient;
using System.Data;


namespace AssignmentDay11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FillAuthorsToGridView();
            
        }










        private void FillAuthorsToGridView()
        {
            // to get db (ip / auth db / connection object [sqlconnection])
            SqlConnection con =
                new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True;Trust Server Certificate=True");
                //modern way //new SqlConnection("Server=AHMED-KHATAB\\SQLEXPRESS;Database=pubs;Trusted_connection=true");

            //command
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from authors";

            //link command to cnnection object
            command.Connection = con;

            //open connection 
            try
            {
                con.Open();
                //query execution
                SqlDataReader dataReader = command.ExecuteReader();

                //data binding
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                // -- datatable has no GUi

                //useing data grid view
                gridAuthors.DataSource = dataTable;


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
