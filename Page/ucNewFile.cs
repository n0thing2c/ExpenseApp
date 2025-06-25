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
using Login.Operation.UserLog;

namespace Login.Page
{
    public partial class ucNewFile : UserControl
    {
        string user;
        string tp;
        public event EventHandler ExitButtonClicked;
        public event Action<string,string> MakeFileClicked;
        public ucNewFile(string username,string type)
        {
            InitializeComponent();
            user = username;
            tp = type;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MakeFileButton_Click_1(object sender, EventArgs e)
        {
            string userFolderPath = Account.GetCurrentAcc().GetFolderPath();
            if (tp == "FM")
            {
                string folder = Path.Combine(userFolderPath, "FMFiles"); 
                string name = new CultureInfo("en-US").DateTimeFormat.GetMonthName(Convert.ToInt32(MonthPicker.Value)) + "_" + Convert.ToString(YearPicker.Value) + "_Expenses.csv";
                string path = Path.Combine(folder, name);
                FMFile file = new FMFile();
                file.Create(path);
                MakeFileClicked?.Invoke(path,tp);
            }
            else if(tp == "MD")
            {
                string folder = Path.Combine(userFolderPath, "MDFiles");
                string name = new CultureInfo("en-US").DateTimeFormat.GetMonthName(Convert.ToInt32(MonthPicker.Value)) + "_" + Convert.ToString(YearPicker.Value) + "_Group_Expenses.csv";
                string path = Path.Combine(folder, name);
                MDFile file = new MDFile();
                file.Create(path);
                MakeFileClicked?.Invoke(path,tp);
            }
        }
    }
}
