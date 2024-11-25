using EFDay1.Models;
using Microsoft.EntityFrameworkCore;
namespace EFDay1
{
    public partial class Form1 : Form
    {
        SchoolContext db;
        public Form1()
        {
            db = new SchoolContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dgv_students.DataSource=    db.Students.Where(n=>n.age>22).ToList();
            dgv_students.DataSource = db.Students.Include(n => n.dept).Select(n => new { n.ID, n.name, n.age, deptname = n.dept.name, location = n.dept.Loc }).ToList();

            cb_dept.DataSource = db.Departments.ToList();
            cb_dept.ValueMember = "ID";
            cb_dept.DisplayMember = "name";

            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                name = txt_name.Text,
                age = int.Parse(txt_age.Text),
                adddress = txt_address.Text,
                deptid = (int)cb_dept.SelectedValue,
            };

            db.Students.Add(s);
            db.SaveChanges();

            dgv_students.DataSource = db.Students.Include(n => n.dept).Select(n => new { n.ID, n.name, n.age, deptname = n.dept.name, location = n.dept.Loc }).ToList();
            txt_address.Text = txt_name.Text = txt_age.Text = "";
            MessageBox.Show("sucessfuly added");
        }
        int id;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_students.SelectedRows[0].Cells[0].Value;

            Student s = db.Students.Where(s => s.ID == id).SingleOrDefault();

            txt_name.Text = s.name;
            txt_age.Text = s.age.ToString();
            txt_address.Text = s.adddress;
            cb_dept.SelectedValue = s.deptid;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.ID == id).SingleOrDefault();
            s.name = txt_name.Text;
            s.age = int.Parse(txt_age.Text);
            s.adddress = txt_address.Text;
            s.deptid = (int)cb_dept.SelectedValue;

            db.SaveChanges();
            dgv_students.DataSource = db.Students.Include(n => n.dept).Select(n => new { n.ID, n.name, n.age, deptname = n.dept.name, location = n.dept.Loc }).ToList();
            txt_address.Text = txt_name.Text = txt_age.Text = "";
            MessageBox.Show("sucessfuly updated");

            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.ID == id).SingleOrDefault();

            db.Students.Remove(s);

            db.SaveChanges();


            dgv_students.DataSource = db.Students.Include(n => n.dept).Select(n => new { n.ID, n.name, n.age, deptname = n.dept.name, location = n.dept.Loc }).ToList();
            txt_address.Text = txt_name.Text = txt_age.Text = "";
            MessageBox.Show("sucessfuly deleted");
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
        }
    }
}
