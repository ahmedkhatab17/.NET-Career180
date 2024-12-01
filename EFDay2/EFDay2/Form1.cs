using EFDay2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompanyContext db = new CompanyContext();
            //dataGridView1.DataSource = db.Employees.Select(n => new {n.id,n.fullname,n.username,n.salary}).ToList();
            //dataGridView1.DataSource = db.Employees.Include(n=>n.department).ToList();
            dataGridView1.DataSource = db.Employees.ToList();
        }
    }
}
