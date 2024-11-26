using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Lab2
{
    public partial class Form1 : Form
    {
        CompanyContext db;
        public Form1()
        {
            db = new CompanyContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CompanyContext db = new CompanyContext();

            dGVEmployee.DataSource = db.Employees.Include(e => e.Dept).Select(e => new { e.SSN, e.FName, e.LName, e.Salary, deptid = e.Dept.DeptId, deptname = e.Dept.DeptName }).ToList();

            comboDept.DataSource = db.Departments.ToList();
            comboDept.ValueMember = "DeptId";
            comboDept.DisplayMember = "DeptName";
            
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            

        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    Employee employee = new Employee()
        //    {
        //        FName = txtFName.Text,
        //        LName = txtLName.Text,
        //        Salary = int.Parse(txtSalary.Text),
        //        DeptId = (int)comboDept.SelectedValue,
        //    };

        //    db.Employees.Add(employee);
        //    db.SaveChanges();

        //    dGVEmployee.DataSource = db.Employees.Include(n => n.Dept).Select(n => new { n.SSN, n.FName, n.LName, n.Salary, deptname = n.Dept.DeptName }).ToList();
        //    txtFName.Text = txtLName.Text = txtSalary.Text = "";
        //    MessageBox.Show("sucessfuly added");
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FName = txtFName.Text,
                LName = txtLName.Text,
                Salary = decimal.Parse(txtSalary.Text),
                DeptId = (int)comboDept.SelectedValue,
            };
            db.Employees.Add(employee);
            db.SaveChanges();

            dGVEmployee.DataSource = db.Employees.Include(e => e.Dept)
                .Select(e => new { e.SSN, e.FName, e.LName, e.Salary, deptid = e.Dept.DeptId, deptname = e.Dept.DeptName })
                .ToList();

            txtFName.Text = txtLName.Text = txtSalary.Text = "";

            MessageBox.Show("Successfully Added");




        }
        int id;
        private void dGVEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dGVEmployee.SelectedRows[0].Cells[0].Value;

            var s = db.Employees.Where(e => e.SSN == id).SingleOrDefault();

            txtFName.Text = s.FName;
            txtLName.Text = s.LName;
            txtSalary.Text = s.Salary.ToString();
            comboDept.SelectedValue = s.DeptId;

            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee s = db.Employees.Where(n => n.SSN == id).SingleOrDefault();
            s.FName = txtFName.Text;
            s.LName = txtLName.Text;
            s.Salary = decimal.Parse(txtSalary.Text);
            s.DeptId = (int)comboDept.SelectedValue;

            db.SaveChanges();

            dGVEmployee.DataSource = db.Employees.Include(e => e.Dept)
                .Select(e => new { e.SSN, e.FName, e.LName, e.Salary, deptid = e.Dept.DeptId, deptname = e.Dept.DeptName })
                .ToList();
            txtFName.Text = txtLName.Text = txtSalary.Text = "";
            MessageBox.Show("Successfully Updated");

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee s = db.Employees.Where(n => n.SSN == id).SingleOrDefault();
            db.Employees.Remove(s);
            db.SaveChanges();
            dGVEmployee.DataSource = db.Employees.Include(e => e.Dept)
                .Select(e => new { e.SSN, e.FName, e.LName, e.Salary, deptid = e.Dept.DeptId, deptname = e.Dept.DeptName })
                .ToList();
            txtFName.Text = txtLName.Text = txtSalary.Text = "";
            MessageBox.Show("Successfully Deleted");

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
        }
    }
}
