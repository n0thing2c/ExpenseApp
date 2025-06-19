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
        public event Action<string> OpenFileClicked;
        public event EventHandler ExitButtonClicked;
        public ucPickFile()
        {
            InitializeComponent();
        }
        UserFolder ff = new UserFolder();
        public void LoadFilesForUser(string username)
        {
            ff.SetUserName(username);
            ff.SetFolder("FMFiles");
            ff.LoadAllFilesToListBox(this.listBoxFiles);
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxFiles.SelectedIndex;
            if (index >= 0 && index < ff.GetNumberOfFiles())
            {
                string filePath = ff.GetFilePathAtIndex(index);
                ShowFileContent(filePath);
            }

        }
        private void ShowFileContent(string filePath)
        {
            LoadFileForm l = new LoadFileForm(filePath);
            this.Hide();
            l.ShowDialog();
            this.Show();
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
                ff.DeleteFileAtIndex(index);
                listBoxFiles.Items.RemoveAt(index);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a file", "File not selected yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filePath = ff.GetFilePathAtIndex(listBoxFiles.SelectedIndex);
            OpenFileClicked?.Invoke(filePath);
        }
    }
}
