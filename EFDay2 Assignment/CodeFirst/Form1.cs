using CodeFirst.Models;

namespace CodeFirst
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
            dataGridView1.DataSource = db.News.ToList();
        }
    }
}
