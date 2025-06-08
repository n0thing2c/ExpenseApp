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
    public partial class NewFileForm : Form
    {
        string user;
        public NewFileForm(string username)
        {
            InitializeComponent();
            user= username;
        }
        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new MenuForm(user).Show();
            this.Hide();
        }

        private void MakeFileButton_Click_1(object sender, EventArgs e)
        {
            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folder = Path.Combine(repoPath, "Operation","UserFiles",user,"FMFiles");
            string name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(MonthPicker.Value)) + "_" + Convert.ToString(YearPicker.Value) + "_Expenses.csv";
            string path = Path.Combine(folder, name);
            FMFile file = new FMFile();
            file.Create(path);
            this.Hide();
            LoadFileForm l = new LoadFileForm(path);
            this.Close();
            l.Show();
        }

        
    }
}
