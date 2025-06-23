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
    public partial class ucLogIn : UserControl
    {
        private readonly LoginForm view;
        private readonly Account acc;
        string repoPath;
        public ucLogIn(LoginForm form, Account account)
        {
            view = form;
            acc = account;
            repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            view.SignInClicked += LogInClickedControll;
            InitializeComponent();
        }
       private void LogInClickedControll(object sender, EventArgs e)
        {
            if(acc.isValid())
            {
                string user = acc.getUserName();
                string pass = acc.getPassword();
                string path = Path.Combine(repoPath, "Operation", "UserInfo", "info.txt");
                string convert = user + ":" + pass;
                File.AppendAllText(path, user + Environment.NewLine);
                File.AppendAllText(path, pass + Environment.NewLine);
                new MenuForm(acc.getUserName()).Show();
                view.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect, please try again");
                view.txtPassword.Clear();
                view.txtUsername.Clear();
                view.txtUsername.Focus();
            }    
        }
   
    }
}
