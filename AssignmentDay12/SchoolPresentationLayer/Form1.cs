
using SchoolBusinessLayer;
using System.Net;

namespace SchoolPresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillStudentInGridView();
        }

        private void FillStudentInGridView()
        {
            dataGridView1.DataSource = SchoolBusinessLayer.StudentBusinessLayer.GetAll();
            comboBox1.DataSource = SchoolBusinessLayer.StudentBusinessLayer.GetAll();
            comboBox1.DisplayMember = "St_fname";
            comboBox1.ValueMember = "St_Id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                St_id = txtId.Text,
                St_fname = txtFName.Text,
                St_lname = txtLName.Text,
                St_Address = txtAddress.Text
            };
            var affected = SchoolBusinessLayer.StudentBusinessLayer.Add(s);
            label5.Text = $"{affected.ToString()} Row Inserted";
            FillStudentInGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var DT = SchoolBusinessLayer.StudentBusinessLayer.GetOne(comboBox1.SelectedValue.ToString());
            txtId.Text = DT.Rows[0]["st_id"].ToString();
            txtFName.Text = DT.Rows[0]["st_fname"].ToString();
            txtLName.Text = DT.Rows[0]["st_lname"].ToString();
            txtAddress.Text = DT.Rows[0]["st_address"].ToString();
            txtId.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                St_id = txtId.Text,
                St_fname = txtFName.Text,
                St_lname = txtLName.Text,
                St_Address = txtAddress.Text
            };
            var affected = SchoolBusinessLayer.StudentBusinessLayer.Update(s);
            label5.Text = $"{affected.ToString()} Row Updated";
            FillStudentInGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var affected = SchoolBusinessLayer.StudentBusinessLayer.Delete(comboBox1.SelectedValue.ToString());
            label5.Text = $"{affected.ToString()} Row Deleted";
            FillStudentInGridView();
        }
    }
}
