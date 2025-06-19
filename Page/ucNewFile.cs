using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class ucNewFile : UserControl
    {
        string user;
        public event EventHandler ExitButtonClicked;
        public event Action<string> FileCreated;
        public ucNewFile(string username)
        {
            InitializeComponent();
            user = username;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MakeFileButton_Click_1(object sender, EventArgs e)
        {
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folder = Path.Combine(repoPath, "Operation", "UserFiles", user, "FMFiles");
            string name = new CultureInfo("en-US").DateTimeFormat.GetMonthName(Convert.ToInt32(MonthPicker.Value)) + "_" + Convert.ToString(YearPicker.Value) + "_Expenses.csv";
            string path = Path.Combine(folder, name);
            FMFile file = new FMFile();
            file.Create(path);
            FileCreated?.Invoke(path);
        }
    }
}
