using System;
using System.Windows.Forms;

namespace AtmApp.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            NewUser newuser = new NewUser();
            newuser.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter a username and password");
            } else
            {
                var use = new Program();
                var executeOk = new bool();

                executeOk = use.HandleLogin(textBoxUsername.Text, textBoxPassword.Text);
                if (executeOk)
                {
                    Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bad Username or Password!","Error");
                }
            }
        }
    }
}
