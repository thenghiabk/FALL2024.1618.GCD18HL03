namespace EmployeeManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string userName = txtUserName.Text;
            int age = Convert.ToInt32(txtUserAge.Text);
            
            txtResults.Text = "ID: " + id + "\n, Name: " + userName + "\n, Age: " + age;

        }
    }
}
