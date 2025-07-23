using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Operation.Interface;
using Login.Operation.Presenter;
using Login.Operation.UserLog;

namespace Login.Page
{
    public partial class ucPickFile : UserControl, IPickFileView
    {
        public string type { get; }
        private readonly PickFilePresenter presenter;

        public event Action<string,string> OpenFileClicked;
        public event EventHandler ExitButtonClicked;
        public event EventHandler LoadFilesRequested;
        public event Action<int> OpenFileRequested;
        public event Action<int> DeleteFileRequested;

        public ucPickFile(string tp)
        {
            InitializeComponent();
            type = tp;
            presenter = new PickFilePresenter(this, new FileService());
        }

        //UserFolder folder = Account.GetCurrentAcc().GetUserFolder();
        //public void LoadFilesForUser(string username)
        //{
        //    if(tp=="FM")
        //        folder.SetFolder("FMFiles");
        //    else if(tp=="MD")
        //        folder.SetFolder("MDFiles");
        //    folder.LoadAllFilesToListBox(this.listBoxFiles);
        //}
        //private void OpenButton_Click(object sender, EventArgs e)
        //{
        //    if (listBoxFiles.SelectedIndex < 0)
        //    {
        //        MessageBox.Show("Please select a file", "File not selected yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    string filePath = folder.GetFilePathAtIndex(listBoxFiles.SelectedIndex);
        //    OpenFileClicked?.Invoke(filePath, tp);
        //}
        //private void DeleteButton_Click(object sender, EventArgs e)
        //{

        //    if (listBoxFiles.Items.Count == 0 || MessageBox.Show("Do you want the delete this file?", "Delete Confirmation", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        int index = listBoxFiles.SelectedIndex;
        //        folder.DeleteFileAtIndex(index);
        //        listBoxFiles.Items.RemoveAt(index);
        //    }
        //}
        public void LoadFilesToBox()
        {
            LoadFilesRequested?.Invoke(this, EventArgs.Empty);
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0)
            {
                ShowMessage("Please select a file", "No file selected");
                return;
            }
            OpenFileRequested?.Invoke(listBoxFiles.SelectedIndex);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0)
            {
                ShowMessage("Please select a file", "No file selected");
                return;
            }
            DeleteFileRequested?.Invoke(listBoxFiles.SelectedIndex);
        }

        public void ShowFiles(IList<string> fileNames)
        {
            listBoxFiles.Items.Clear();
            foreach (var name in fileNames)
                listBoxFiles.Items.Add(name);
        }

        public bool ConfirmDelete(string fileName)
        {
            return MessageBox.Show(
                $"Do you want to delete '{fileName}'?",
                "Delete Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK;
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void NotifyFileOpened(string path, string type)
        {
            OpenFileClicked?.Invoke(path, type);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
