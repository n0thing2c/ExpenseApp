using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();

            int lastCharIndex = RTBDescription.TextLength;
            int y = RTBDescription.GetPositionFromCharIndex(lastCharIndex).Y;

            // Ước lượng chiều cao cần thiết (cộng thêm chiều cao 1 dòng + padding)
            int neededHeight = y + RTBDescription.Font.Height + 50;

            // Gán chiều cao cho RichTextBox và panel chứa nó
            RTBDescription.Height = neededHeight;
            Panel_RTBDescription.Height = neededHeight;

            LoadTeamInfo();
            this.MouseDown += Form_MouseDown;
            Debug.WriteLine("Total body content height: " + BodyPanel.DisplayRectangle.Height);
            Debug.WriteLine("Client height: " + BodyPanel.ClientSize.Height);
        }
        private void LoadTeamInfo()
        {
            // Thêm thông tin từng thành viên
            AddMember("Developer Team:");
            AddMember("Huỳnh Gia Khang");
            AddMember("Trần Nguyễn Duy Thịnh");
            AddMember("Trương Tấn Dũng");
            AddMember("Trần Công Hoàng Tấn");
            AddMember("Nguyễn Kinh Quốc");
            ToolTip tip = new ToolTip();
            tip.SetToolTip(LLGitHub, "GitHub của nhóm");
        }

        private void AddMember(string name)
        {
            Label lbl = new Label();
            lbl.Text = name;
            lbl.AutoSize = true;
            lbl.Margin = new Padding(10);
            lbl.Font = new Font("Segoe UI", 9);
            lbl.ForeColor = Color.Black;
            flowLayoutPanelMembers.Controls.Add(lbl); // flowLayoutPanelMembers đã có sẵn trong Form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterExitButton()
        {
            // Căn giữa theo chiều ngang
            btnClose.Left = (this.ClientSize.Width - btnClose.Width) / 2;
        }

        private void LLGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/n0thing2c/ExpenseApp",
                UseShellExecute = true
            });
        }
       
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
    }
}
