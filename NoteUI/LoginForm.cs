using MongoDB.Bson.Serialization;
using NoteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NoteUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_Closing;
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancel the closing operation
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text != "" && emailTxtBox.Text != "")
            {
                if (IsEmailValid(emailTxtBox.Text))
                {

                }
                else
                {
                    MessageBox.Show("Please enter a valid email address!");
                    emailTxtBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter your user name and email address!");
            }
        }
        public static bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
