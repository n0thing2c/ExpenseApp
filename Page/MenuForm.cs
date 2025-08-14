using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Login.Operation.ChartHandle;
using Login.Operation.UserLog;
namespace Login.Page
{
    public partial class MenuForm : Form
    {
        private readonly Account acc;
        string user;
        private ExpenseRecord expenseRecord = new ExpenseRecord();
        private DrawChart ucDrawChart;
        public MenuForm(string username)
        {
            user = username;
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Name = "ucCurrent";
            panelContent.Controls.Clear();
            panelContent.Controls.Add(uc);
            uc.Dock = DockStyle.None;
            uc.Anchor = AnchorStyles.None;
            int x = (this.panelContent.Width - uc.Width) / 2;
            int y = (this.panelContent.Height - uc.Height) / 2;
            uc.Location = new Point(x, y);
        }

        private void NewFile_Button_Click(object sender, EventArgs e)
        {
            ucPickFileType ucPFT = new ucPickFileType(user, "New");
            ucPFT.NewFile += NewFileControl;
            ucPFT.ExitClicked += ExitButtonClickedControl;
            LoadUserControl(ucPFT);
        }

        private void PickFile_Button_Click(object sender, EventArgs e)
        {
            ucPickFileType ucPFT = new ucPickFileType(user, "Pick");
            ucPFT.PickFile += PickFileControl;
            ucPFT.ExitClicked += ExitButtonClickedControl;
            LoadUserControl(ucPFT);
        }
        private void NewFileControl(string type)
        {
            ucNewFile ucNF = new ucNewFile(user, type);
            ucNF.ExitClicked += ExitButtonClickedControl;
            ucNF.MakeFileClicked += LoadFileControl;
            LoadUserControl(ucNF);
        }
        private void PickFileControl(string type)
        {
            ucPickFile ucPF = new ucPickFile(type);
            ucPF.LoadFilesToBox();
            ucPF.ExitButtonClicked += ExitButtonClickedControl;
            ucPF.OpenFileClicked += LoadFileControl;
            LoadUserControl(ucPF);
        }

        private void ExitButtonClickedControl(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
        }

        private void LoadFileControl(string filepath, string type)
        {
            if (panel2.Visible == panel1.Visible)
            {
                panel2.Visible = !panel2.Visible;
            }
            NotificationList_panel.Visible = panel2.Visible;
            User_Panel.Visible = panel2.Visible;
            if (type == "FM")
            {
                ucLoadFMFile ucLF = new ucLoadFMFile();
                ucLF.Dock = DockStyle.Fill;
                ucLF.Anchor = AnchorStyles.None;
                LoadUserControl(ucLF);
                ucLF.ExitButtonClicked += ExitButtonClickedControl;
                ucLF.LoadFile(filepath);
            }
            else if (type == "MD")
            {
                ucLoadMDFile ucMD = new ucLoadMDFile();
                ucMD.Dock = DockStyle.Fill;
                ucMD.Anchor = AnchorStyles.None;
                LoadUserControl(ucMD);
                ucMD.ExitButtonClicked += ExitButtonClickedControl;
                ucMD.LoadFile(filepath);
            }
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            PickFile_Button.Visible = panel2.Visible;
            NewFile_Button.Visible = panel2.Visible;
            Exit_Button.Visible = panel2.Visible;
            AboutUs_Button.Visible = panel2.Visible;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Notification_Button_Click(object sender, EventArgs e)
        {
            NotificationList_panel.Visible = !NotificationList_panel.Visible;
        }

        private void Personal_Button_Click(object sender, EventArgs e)
        {
            User_Panel.Visible = !User_Panel.Visible;
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("Do you really want to log out", "Confirm Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        private void DrawChart_button_Click(object sender, EventArgs e)
        {
            ucPickChartType ucPCT = new ucPickChartType();
            ucPCT.PieChart += PickFile;
            ucPCT.LineChart += DrawLineChartControl;
            ucPCT.ExitClicked += ExitButtonClickedControl;
            LoadUserControl(ucPCT);
        }

        private void PickFile(object sender, EventArgs e)
        {
            ucPickFile ucPF = new ucPickFile("FM");
            ucPF.LoadFilesToBox();
            ucPF.ExitButtonClicked += ExitButtonClickedControl;
            ucPF.OpenFileClicked += drawPieChartControl;
            LoadUserControl(ucPF);
        }

        private void drawPieChartControl(string filepath, string type)
        {
            type = "FM";
            var records = expenseRecord.ReadCSV(filepath);
            var categoryExpenses = expenseRecord.GetCategoryExpenses(records);
            ucDrawChart = new DrawChart(expenseRecord);
            ucDrawChart.drawPieChart(categoryExpenses);
            LoadUserControl(ucDrawChart);
        }

        private string GetFMFolder()
        {
            string folderPath = Account.GetCurrentAcc().GetUserFolder().GetFolderPath();
            string FMFolderPath = Path.Combine(folderPath, "FMFiles");
            return FMFolderPath;
        }

        private void DrawLineChartControl(object sender, EventArgs e)
        {
            string folder = GetFMFolder();
            var CSVFiles = Directory.GetFiles(folder, "*.csv");
            if (CSVFiles.Length == 0)
            {
                MessageBox.Show("No data to show");
                return;
            }

            Dictionary<string, long> monthlyExpense = expenseRecord.GetMonthlyExpense(CSVFiles);
            ucDrawChart = new DrawChart(expenseRecord);
            ucDrawChart.drawLineChart(monthlyExpense);
            LoadUserControl(ucDrawChart);
        }
        private void AboutUs_Button_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutUsForm();
            aboutForm.ShowDialog();
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
        }
    } 
}
