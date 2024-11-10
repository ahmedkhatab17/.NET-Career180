namespace WinFormsFirstLook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //callback method
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellooooo", "Warning", MessageBoxButtons.CancelTryContinue);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
