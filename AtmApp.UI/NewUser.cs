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
                MessageBox.Show("Please enter all required data");
            }
            else
            {
                var executionOk = Program.InsertNewUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxUsername.Text, textBoxPassword.Text);
                if (executionOk)
                {
                    MessageBox.Show("User created!");
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Error, User not created!");
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