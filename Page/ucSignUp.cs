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
    public partial class ucSignUp : UserControl
    {
        private readonly SignUpForm view;
        private readonly string repoPath;
        public ucSignUp(SignUpForm form)
        {
            view = form;
            view.SignUpClicked += SignUpClickedControl;
            repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            InitializeComponent();
        }
        private void SignUpClickedControl(object sender, EventArgs e)
        {
            string user = view.getUserName();
            string pass = view.getPassword();
            if (checkExistedUsername(user))
            {
                MessageBox.Show("Username already existed, please choose another one");
                view.txtUsername.Clear();
                view.txtPassword.Clear();
                view.txtUsername.Focus();
            }
            else
            {
                this.signUp(user, pass);
                MessageBox.Show("Sign up successfully, Log in to continue");
                view.Hide();
                new LoginForm().Show();
            }
        }
        public void signUp(string user, string pass)
        {
            string convert = user + ":" + pass;
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");
            try
            {
                //Account.ModifyAcc(user, pass); //Create new account
                File.AppendAllText(path, convert + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }

        }
        private bool checkExistedUsername(string username)
        {
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");
            List<string> infos = new List<string>(File.ReadAllLines(path));
            string find = username;
            foreach (string info in infos)
            {
                string user = info.Split(':')[0];
                if (user == find)
                    return true;
            }
            return false;
        }
      
    }
}
