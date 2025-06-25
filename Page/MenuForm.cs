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
    public partial class MenuForm : Form
    {
        string user;
        public MenuForm(string username)
        {
            user= username;
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

        private void LoadFile_Button_Click(object sender, EventArgs e)
        {
            ucPickFileType ucPFT = new ucPickFileType(user, "Pick");
            ucPFT.PickFile += PickFileControl;
            ucPFT.ExitClicked += ExitButtonClickedControl;
            LoadUserControl(ucPFT);
        }
        private void NewFileControl(string type)
        {
            ucNewFile ucNF = new ucNewFile(user,type);
            ucNF.ExitButtonClicked += ExitButtonClickedControl;
            ucNF.MakeFileClicked += LoadFileControl;
            LoadUserControl(ucNF);
        }
        private void PickFileControl(string type)
        {
            ucPickFile ucPF = new ucPickFile(type);
            ucPF.LoadFilesForUser(user);
            ucPF.ExitButtonClicked += ExitButtonClickedControl;
            ucPF.OpenFileClicked += LoadFileControl;
            LoadUserControl(ucPF);
        }

        private void ExitButtonClickedControl(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
        }

        private void LoadFileControl(string filepath,string type)
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
            else if(type =="MD")
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
            LoadFile_Button.Visible = panel2.Visible;
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
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("Do you really want to log out", "Confirm Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


    }
}
