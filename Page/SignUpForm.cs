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
using Login.Operation.Interface;
using Login.Operation.Presenter;
using Login.Operation.UserLog;
namespace Login.Page
{
    public partial class SignUpForm : Form,IAuthView
    {
        private readonly SignUpPresenter presenter;
        public SignUpForm()
        {
            InitializeComponent();
            presenter = new SignUpPresenter(this);
        }
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        public void NavigateTo(string username)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
           presenter.HandleSignUp();
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
