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
namespace Login.Page
{
    public partial class SignUpControl : Form
    {
        public SignUpControl()
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
                Account acc = new Account(txtUsername.Text, txtPassword.Text);
                acc.signUp();
                acc.createUserFolder();
                MessageBox.Show("Sign up successfully, Log in to continue");
                this.Hide();
                new LoginControl().Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void closeEye_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                closeEye.Hide();
                openEye.Show();
            }
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '•';
                openEye.Hide();
                closeEye.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
