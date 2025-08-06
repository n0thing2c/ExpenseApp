using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Operation.Interface;

namespace Login.Operation.Presenter
{
    public class SignUpPresenter
    {
        private readonly IAuthView view;
        private readonly string repoPath;
        public SignUpPresenter(IAuthView signUpview)
        {
            this.view = signUpview;
            this.repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName; ;
        }
        public void HandleSignUp()
        {
            string user = view.Username;
            string pass = view.Password;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                view.ShowMessage("Username or password is not filled, please try again");
                view.ClearFields();
                return;
            }

            if (CheckExistedUsername(user))
            {
                view.ShowMessage("Username already existed, please choose another one");
                view.ClearFields();
                return;
            }

            CreateNew(user, pass);
            view.ShowMessage("Sign up successfully, Log in to continue");
            view.NavigateTo(user);
        }
        bool CheckExistedUsername(string username)
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
        public void CreateNew(string user, string pass)
        {
            string convert = user + ":" + pass;
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");
            try
            {
                File.AppendAllText(path, convert + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }

        }
    }
}
