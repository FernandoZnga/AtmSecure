﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtmApp.UI;
using AtmApp.Domain;

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
                var user = new User() {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    UserName = textBoxUsername.Text,
                    PassWord = textBoxPassword.Text
                };
                var account = new Account()
                {
                    User = user
                };
                var handle = new Program();
                var executionOk = handle.InsertNewUser(user, account);
                if (executionOk)
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
