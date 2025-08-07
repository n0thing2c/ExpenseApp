using Login.Operation.UserLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Login.Page
{
    public class UserFolder
    {
        private string username;
        private string FolderPath; //Path to the folder containing user files
        private string targetFolder; // Path to the specific folder (FM or MD files)
        private List<string> filePaths;
        public UserFolder()
        {
            targetFolder = "";
            filePaths= new List<string>();
        }
        
        public void SetUserName(string name)
        {
            username = name;
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            FolderPath = Path.Combine(repoPath, "Operation", "UserFiles", username);
        }
        
        public string GetFolderPath()
        {
            return FolderPath;
        }
    }
}
