
using Company.BusinessLayer;

namespace Company.PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillAuthorsList();
        }

        private void FillAuthorsList()
        {
            dataGridView1.DataSource = Company.BusinessLayer.AuthorBL.GetAll();
            comboBox1.DataSource = Company.BusinessLayer.AuthorBL.GetAll();
            comboBox1.DisplayMember = "au_fname";
            comboBox1.ValueMember = "au_id";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Author a = new Author
            {
                Au_id = txtId.Text,
                Au_fname = txtFName.Text,
                Au_lname = txtLName.Text,
                Address = txtAddress.Text
            };
            var affected = Company.BusinessLayer.AuthorBL.Add(a);
            label5.Text = affected.ToString();
            FillAuthorsList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var DT = Company.BusinessLayer.AuthorBL.GetOne(comboBox1.SelectedValue.ToString());
            txtId.Text = DT.Rows[0]["au_id"].ToString();
            txtFName.Text = DT.Rows[0]["au_fname"].ToString();
            txtLName.Text = DT.Rows[0]["au_lname"].ToString();
            txtAddress.Text = DT.Rows[0]["address"].ToString();
            txtId.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Author a = new Author
            {
                Au_id = txtId.Text,
                Au_fname = txtFName.Text,
                Au_lname = txtLName.Text,
                Address = txtAddress.Text
            };
            var affected = Company.BusinessLayer.AuthorBL.Update(a);
            label5.Text = affected.ToString();
            FillAuthorsList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var affected = Company.BusinessLayer.AuthorBL.Delete(comboBox1.SelectedValue.ToString());
            label5.Text = affected.ToString();
            FillAuthorsList();
        }
    }
}
