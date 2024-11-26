using Microsoft.Data.SqlClient;
using System.Data;

namespace AssignmentDay12
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;


        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=AHMED-KHATAB\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dt = new DataTable();

            FillStudentToGridView();
        }

        private void FillStudentToGridView()
        {
            command.CommandText = "select St_Id as ID, St_Fname as FirstName, St_Lname as LastlName, St_Address as Address, St_Age as Age from Student";
            command.Connection = con;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            gridStudent.DataSource = dt;



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["ID"] = txtId.Text;
            dr["FirstName"] = txtFName.Text;
            dr["LastlName"] = txtLName.Text;
            dr["Address"] = txtAddress.Text;
            dr["Age"] = txtAge.Text;

            dt.Rows.Add(dr);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            
                // Insert Command
                SqlCommand InsCommand = new SqlCommand();
                InsCommand.CommandText = "insert into Student (St_Id, St_Fname, St_Lname, St_Address, St_Age) VALUES (@St_Id, @St_Fname, @St_Lname, @St_Address, @St_Age)";
                InsCommand.Parameters.Add("@St_Id", SqlDbType.VarChar, 20, "ID");
                InsCommand.Parameters.Add("@St_Fname", SqlDbType.VarChar, 50, "FirstName");
                InsCommand.Parameters.Add("@St_Lname", SqlDbType.VarChar, 50, "LastName");
                InsCommand.Parameters.Add("@St_Address", SqlDbType.VarChar, 100, "Address");
                InsCommand.Parameters.Add("@St_Age", SqlDbType.VarChar, 20, "Age");
                InsCommand.Connection = con;

                // Update Command
                SqlCommand UpdCommand = new SqlCommand();
                UpdCommand.CommandText = "update Student set St_Fname = @St_Fname, St_Lname = @St_Lname, St_Address = @St_Address, St_Age = @St_Age WHERE St_Id = @St_Id";
                UpdCommand.Parameters.Add("@St_Id", SqlDbType.VarChar, 20, "ID");
                UpdCommand.Parameters.Add("@St_Fname", SqlDbType.VarChar, 50, "FirstName");
                UpdCommand.Parameters.Add("@St_Lname", SqlDbType.VarChar, 50, "LastName");
                UpdCommand.Parameters.Add("@St_Address", SqlDbType.VarChar, 100, "Address");
                UpdCommand.Parameters.Add("@St_Age", SqlDbType.VarChar, 20, "Age");
                UpdCommand.Connection = con;

                // Delete Command
                SqlCommand DelCommand = new SqlCommand();
                DelCommand.CommandText = "delete from Student where St_Id = @St_Id";
                DelCommand.Parameters.Add("@St_Id", SqlDbType.VarChar, 20, "ID");
                DelCommand.Connection = con;

                // Assign commands to adapter
                adapter.InsertCommand = InsCommand;
                adapter.UpdateCommand = UpdCommand;
                adapter.DeleteCommand = DelCommand;

                // Apply changes to the database
                adapter.Update(dt);

                
                
            
        }
    }
}
