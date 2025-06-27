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
            this.signUp(user, pass);
            MessageBox.Show("Sign up successfully, Log in to continue");
            view.Hide();
            new LoginForm().Show();
        }
        public void signUp(string user, string pass)
        {
            
            string convert = user + ":" + pass;
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");
            try
            {
                Account.ModifyAcc(user, pass); //Create new account
                File.AppendAllText(path, convert + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }

        }

        private void ucSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
