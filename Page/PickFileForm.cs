using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{

    public partial class PickFileForm : Form
    {

        
        UserFolder ff = new UserFolder();
        public PickFileForm(string username)
        {
            ff.SetUserName(username);
            ff.SetFolder("FMFiles");
            InitializeComponent();
            ff.LoadAllFilesToListBox(listBoxFiles);
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
            this.Close();
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
