namespace EmployeeManagementApp
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            bindingSource.DataSource = users;

            dgvUserList.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string userName = txtUserName.Text;
            int age = Convert.ToInt32(txtUserAge.Text);

            User newUser = new User(id, userName, age);
            newUser.Bonus = calculateBonus(age);

            users.Add(newUser);

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string result = "";

            foreach (var user in users)
            {
                result += "ID: " + user.Id + " Name: " + user.Name + " Age: " + user.Age + " Bonus: " + user.Bonus + "\n";

                result += "\n";
            }

            txtResults.Text = result;

            bindingSource.ResetBindings(false);
        }

        private double calculateBonus(int userAge)
        {
            double bonus = 0.0;

            if (userAge >= 10 && userAge < 18)
            {
                bonus = 0.2;
            }
            else if (userAge >= 18 && userAge < 25)
            {
                bonus = 0.1;
            }
            else if (userAge >= 25 && userAge < 55)
            {
                bonus = 0;
            }
            else
            {
                bonus = 1.0;
            }

            return bonus;
        }
    }
}
