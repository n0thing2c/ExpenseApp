using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class ucPickFile : UserControl
    {
        string tp;
        public event Action<string,string> OpenFileClicked;
        public event EventHandler ExitButtonClicked;
        public ucPickFile(string type)
        {
            InitializeComponent();
            tp = type;
        }
        UserFolder folder = new UserFolder();
        public void LoadFilesForUser(string username)
        {
            folder.SetUserName(username);
            if(tp=="FM")
                folder.SetFolder("FMFiles");
            else if(tp=="MD")
                folder.SetFolder("MDFiles");
            folder.LoadAllFilesToListBox(this.listBoxFiles);
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a file", "File not selected yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filePath = folder.GetFilePathAtIndex(listBoxFiles.SelectedIndex);
            OpenFileClicked?.Invoke(filePath, tp);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (listBoxFiles.Items.Count == 0 || MessageBox.Show("Do you want the delete this file?", "Delete Confirmation", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            else
            {
                int index = listBoxFiles.SelectedIndex;
                folder.DeleteFileAtIndex(index);
                listBoxFiles.Items.RemoveAt(index);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
