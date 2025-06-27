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
using Login;   
using Login.Operation.UserLog;

namespace Login.Page
{
    public partial class LoginForm : Form
    {
        public event EventHandler SignInClicked;

        private readonly ucLogIn LogInController;
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
            Account acc = Account.ModifyAcc(txtUsername.Text, txtPassword.Text);
            ucLogIn uc = new ucLogIn(this,acc);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or password is not filled, please try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                SignInClicked?.Invoke(this, EventArgs.Empty);
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
