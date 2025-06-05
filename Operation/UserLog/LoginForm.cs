using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;

namespace Login.Operation.UserLog
{
    public class LoginForm
    {
        private static string path = "D:\\UI\\Login\\Operation\\UserLog\\userPass.txt";
        private string user;
        private string pass;

        public LoginForm() { }
        public LoginForm(string username, string password)
        {
            user = username;
            pass = password;
        }
        public void signUp()
        {
            string convert = user + ":" + pass;
            File.AppendAllText(path, convert + Environment.NewLine);
        }
        public bool isValid()
        {
            try
            {
                List<string> infos = new List<string>(File.ReadAllLines(path));
                string find = user + ":" + pass;
                foreach(string info in infos)
                {
                    if(info.Contains(find))
                        return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine("File error: " + ex.Message);
                return false;
            }
        }
    }
}
