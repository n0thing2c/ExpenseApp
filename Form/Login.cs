using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Operation.UserLog;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();

            this.Hide();
        }
        private void Login_Button(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm(txtUsername.Text, txtPassword.Text);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or password is not filled, please try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }

            else if (log.isValid())
            {
                string path = "D:\\UI\\Login\\Operation\\UserInfo\\info.txt";
                string convert = txtUsername.Text + ":" + txtPassword.Text;
                File.AppendAllText(path, convert + Environment.NewLine);
                //new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect, please try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            if(eyeIcon.Image == openEye)
            {
                eyeIcon.Image = closeEye;
                txtPassword.PasswordChar = '•';
            }
            else
            {
                eyeIcon.Image = openEye;
                txtPassword.PasswordChar = '\0';
            }
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
