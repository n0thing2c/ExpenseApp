using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Login.Operation.Interface;
using Login.Operation.Presenter;
using Login.Operation.UserLog;

namespace Login.Page
{
    public partial class ucNewFile : UserControl, INewFileView
    {
        string tp;
        NewFilePresenter presenter;

        public event EventHandler ExitClicked;
        public event Action<string, string> MakeFileClicked;
        public event EventHandler MakeFileRequested;
        public ucNewFile(string username,string type)
        {
            InitializeComponent();
            tp = type;
            presenter = new NewFilePresenter(this);
        }
        public string userFolderPath => Account.GetCurrentAcc().GetFolderPath();
        public string type => tp;
        public int selectedMonth => Convert.ToInt32(MonthPicker.Value);
        public int selectedYear => Convert.ToInt32(YearPicker.Value);


        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitClicked?.Invoke(this, EventArgs.Empty);
        }
        public void NotifyFileCreated(string path, string type)
        {
            MakeFileClicked?.Invoke(path, type);
        }
        public bool OverWriteExistFile(string name)
        {
            DialogResult result = MessageBox.Show(
            "The file for " + name.Replace("_", " ").Replace(".csv", "") + 
            " is already created." + " Do you want to overwrite it?",
            "File Already Exists",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
        private void MakeFileButton_Click(object sender, EventArgs e)
        {
            MakeFileRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
