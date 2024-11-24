using Microsoft.Data.SqlClient;
using System.Data;

namespace DisconnectedMode
{
    public partial class Form1 : Form
    {
        //
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        //
        public Form1()
        {
            con = new SqlConnection("Data Source=DESKTOP-MFABGAV;Initial Catalog=pubs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            InitializeComponent();
            FillAuthorsToGridView();
        }

        private void FillAuthorsToGridView()
        {
            command.CommandText = "select au_id,au_fname,au_lname,address from authors";
            command.Connection = con;

            //disconnected mode
            //adapter
            //Fill() -> 1-open con 2-execute command 3- fill into container in ram 4- close con

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            //data binding
            gridAuthors.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["au_id"] = txtId.Text;
            dr["au_fname"] = txtFName.Text;
            dr["au_lname"] = txtLName.Text;
            dr["address"] = txtAddress.Text;

            //REMEMBER to Add new row to Datatable
            dt.Rows.Add(dr);

            //additional for asp.net web forms [legacy]
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            //Insert
            SqlCommand InsCommand = new SqlCommand();
            InsCommand.CommandText = "insert into authors (au_id,au_fname,au_lname,address) values (@id,@fn,@ln,@address)";
            InsCommand.Parameters.Add("@id", SqlDbType.VarChar, 20, "au_id");
            InsCommand.Parameters.Add("@fn", SqlDbType.VarChar, 20, "au_fname");
            InsCommand.Parameters.Add("@ln", SqlDbType.VarChar, 20, "au_lname");
            InsCommand.Parameters.Add("@address", SqlDbType.VarChar, 20, "address");
            InsCommand.Connection = con;
            //

            //Update
            SqlCommand UpdCommand = new SqlCommand();
            UpdCommand.CommandText = "update authors set au_fname=@fn,au_lname=@ln,address=@address where au_id=@id";
            UpdCommand.Parameters.Add("@id", SqlDbType.VarChar, 20, "au_id");
            UpdCommand.Parameters.Add("@fn", SqlDbType.VarChar, 20, "au_fname");
            UpdCommand.Parameters.Add("@ln", SqlDbType.VarChar, 20, "au_lname");
            UpdCommand.Parameters.Add("@address", SqlDbType.VarChar, 20, "address");
            UpdCommand.Connection = con;
            //

            //Delete
            SqlCommand DelCommand = new SqlCommand();
            DelCommand.CommandText = "delete from authors where au_id=@id";
            DelCommand.Parameters.Add("@id", SqlDbType.VarChar, 20, "au_id");
            DelCommand.Connection = con;
            //

            adapter.UpdateCommand = UpdCommand;
            adapter.InsertCommand = InsCommand;
            adapter.DeleteCommand = DelCommand;

            //Return 1-open 2-sync 3-close   Update() 
            adapter.Update(dt);

        }
    }
}
