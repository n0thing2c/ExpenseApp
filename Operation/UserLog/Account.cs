using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Page;

namespace Login.Operation.UserLog
{
    public class Account
    {
        private string user;
        private string pass;
        private UserFolder folder;
        private static Account currentAcc;
        private Account() { }
        private Account(string username, string password)
        {
            user = username;
            pass = password;
            folder = new UserFolder();
            folder.SetUserName(username);
            string folderPath = folder.GetFolderPath();
            Directory.CreateDirectory(Path.Combine(folderPath, "FMFiles"));
            Directory.CreateDirectory(Path.Combine(folderPath, "MDFiles"));
        }
        public static Account GetCurrentAcc()
        {
            if (currentAcc == null)
            {
                throw new InvalidOperationException("No account is currently set.");
            }
            return currentAcc;
        }
        public static Account ModifyAcc(string username, string password)
        {
            if (currentAcc == null)
            {
                currentAcc = new Account(username, password);
            }
            else
            {
                string oldUser = currentAcc.user;
                string newUser = username;
                // Update the folder path
                if (oldUser != newUser)
                {
                    string oldPath = currentAcc.folder.GetFolderPath();
                    currentAcc.folder.SetUserName(username);
                    string newPath = currentAcc.folder.GetFolderPath();
                    Directory.Move(oldPath, newPath);
                }
                currentAcc.user = username;
                currentAcc.pass = password;
            }    
            return currentAcc;
        }
       
        public string getUserName()
        {
            return user;
        }
        public string getPassword()
        {
            return pass;
        }

        public bool isValid()
        {
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");
            try
            {
                List<string> infos = new List<string>(File.ReadAllLines(path));
                string find = user + ":" + pass;
                foreach (string info in infos)
                {
                    if (info.Contains(find))
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
                return false;
            }
        }

    }
}
