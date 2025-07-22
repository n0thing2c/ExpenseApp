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
using Login.Operation.Interface;
using Login.Operation.Presenter;
using Login.Operation.UserLog;

namespace Login.Page
{
    public partial class LoginForm : Form, IAuthView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        public void NavigateToMenu(string username)
        {
            new MenuForm(username).Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
            this.Hide();
        }
        private void Login_Button(object sender, EventArgs e)
        {
            presenter.HandleLogin();
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
    }
}
