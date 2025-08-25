using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Operation.Interface;
using Login.Operation.UserLog;

namespace Login.Operation.Presenter
{
    public class LoginPresenter
    {
        private readonly IAuthView view;
        private readonly string repoPath;

        public LoginPresenter(IAuthView loginView)
        {
            view = loginView;
            repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        }

        public void HandleLogin()
        {
            var acc = Account.ModifyAcc(view.Username, view.Password);

            if (string.IsNullOrEmpty(view.Username) || string.IsNullOrEmpty(view.Password))
            {
                view.ShowMessage("Username or password is not filled, please try again");
                view.ClearFields();
                return;
            }

            if (acc.isValid())
            {
                SaveUserInfo(acc);
                view.NavigateTo(acc.getUserName());
            }
            else
            {
                view.ShowMessage("Username or password is incorrect, please try again");
                view.ClearFields();
            }
        }

        private void SaveUserInfo(Account acc)
        {
            string path = Path.Combine(repoPath, "Operation", "UserInfo", "info.txt");
            var infos = File.ReadAllLines(path).ToList();
            if (!infos.Contains(acc.getUserName()))
            {
                File.AppendAllText(path, acc.getUserName() + Environment.NewLine);
            }
        }
    }

}
