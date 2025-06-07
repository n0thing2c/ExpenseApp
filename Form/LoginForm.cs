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
using Login.Form;
using Login.Operation.UserLog;

namespace Login
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();

            this.Hide();
        }
        private void Login_Button(object sender, EventArgs e)
        {
            Account acc = new Account(txtUsername.Text, txtPassword.Text);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or password is not filled, please try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }

            else if (acc.isValid())
            {
                string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string path = Path.Combine(repoPath, "Operation", "UserInfo", "info.txt");
                string convert = txtUsername.Text + ":" + txtPassword.Text;
                File.AppendAllText(path, txtUsername.Text + Environment.NewLine);
                File.AppendAllText(path, txtPassword.Text + Environment.NewLine);
                new MenuForm().Show();
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void closeEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                closeEye.Hide();
                openEye.Show();
            }
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '•';
                openEye.Hide();
                closeEye.Show();
            }
        }
    }
}
