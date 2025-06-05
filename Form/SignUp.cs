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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in all information");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                LoginForm log = new LoginForm(txtUsername.Text, txtPassword.Text);
                log.signUp();
                MessageBox.Show("Sign up successfully, Log in to continue");
                this.Hide();
                new Login().Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {

            if (eyeIcon.Image == openEye)
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
            if(e.KeyCode == Keys.Enter)
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
                signUpButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
