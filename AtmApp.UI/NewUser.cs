using System;
using System.Windows.Forms;

namespace AtmApp.UI
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == ""
                || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter all required data","Warning");
            }
            else
            {
                var use = new Program();
                var executeOk = new bool();

                executeOk = use.HandleNewUser(
                    textBoxFirstName.Text, textBoxLastName.Text,
                    textBoxUsername.Text, textBoxPassword.Text);
                if (executeOk)
                {
                    MessageBox.Show("User created!","Success");
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("User not created!","Error");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
