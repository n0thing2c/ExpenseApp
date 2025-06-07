using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Operation.UserLog
{
    internal class Account
    {
        private string user;
        private string pass;
        public Account() { }
        public Account(string username, string password)
        {
            user = username;
            pass = password;
        }
        public void signUp()
        {
            string convert = user + ":" + pass;
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string path = Path.Combine(repoPath, "Operation", "UserLog" , "userPass.txt");
            try
            {
                File.AppendAllText(path, convert + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
           
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
