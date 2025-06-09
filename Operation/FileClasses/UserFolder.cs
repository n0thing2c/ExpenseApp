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
    internal class UserFolder
    {
        Account acc;
        private string username;
        private string targetFolder;
        private List<string> filePaths;
        public UserFolder()
        {
            targetFolder = "";
            filePaths= new List<string>();
        }
        public UserFolder(string location)
        {
            this.username = "";
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folder = Path.Combine(repoPath, "Operation","UserFiles",username,location);
            targetFolder = folder;
            filePaths= new List<string>();
        }
        public void SetUserName(string name)
        {
            username = name;
        }
        public void SetFolder(string location)
        {
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folder = Path.Combine(repoPath, "Operation","UserFiles", username, location);
            targetFolder = folder;
            filePaths = new List<string>();
        }
        public int GetNumberOfFiles()
        {
            return filePaths.Count; 
        }
        public string GetFilePathAtIndex(int idx)
        {
            return filePaths[idx];
        }
        public void DeleteFileAtIndex(int idx)
        {
            if (idx >= 0 && idx < filePaths.Count)
            {
                string filePath = filePaths[idx];
                File.Delete(filePath);
            }
        }
        public void LoadAllFilesToListBox(ListBox lb)
        {
            if (Directory.Exists(targetFolder))
            {
                lb.Items.Clear();
                filePaths.Clear();
                string[] files = Directory.GetFiles(targetFolder);
                foreach (string file in files)
                {
                    lb.Items.Add(Path.GetFileName(file.Remove(file.Length - 4).Substring(file.LastIndexOf('\\') + 1).Replace('_', ' '))); // display name
                    filePaths.Add(file); // keep full path
                }
            }
            else
            {
                MessageBox.Show("Folder does not exist: " + targetFolder);
            }
        }
    }
}
