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

            //this.Size = new Size(900, 675);
            //this.MinimumSize = this.Size;  // Ngăn người dùng resize nhỏ hơn
            ////this.MaximumSize = this.Size;  // Giữ tỉ lệ cố định nếu muốn
            ////this.MaximizeBox = false;

            LoadTeamInfo();
            this.MouseDown += Form_MouseDown;
            CenterLabel(labelTitle);
            CenterLabel(labelDescription);
            CenterFlowLayoutPanel();
            CenterExitButton();
        }
        private void LoadTeamInfo()
        {
            labelTitle.Text = "ABOUT US";
            labelProject.Text = "Dự án: ...";
            pictureBoxGroup.Size = new Size(100, 100); // hoặc theo ảnh bạn muốn
            pictureBoxGroup.SizeMode = PictureBoxSizeMode.Zoom; // hiển thị ảnh đẹp
            pictureBoxGroup.Left = (this.ClientSize.Width - pictureBoxGroup.Width) / 2;
            pictureBoxGroup.Top = labelProject.Bottom + 10;
            labelDescription.Text = "Đây là ứng dụng quản lý...., hỗ trợ thêm, sửa, xoá " +
                        "và tìm kiếm thông tin .....";
            labelDescription.MaximumSize = new Size((int)(this.ClientSize.Width * 0.8), 0);
            labelDescription.AutoSize = true;
            labelDescription.TextAlign = ContentAlignment.MiddleCenter;
            labelDescription.Left = (this.ClientSize.Width - labelDescription.Width) / 2;
            labelDescription.Top = pictureBoxGroup.Bottom + 10; 
            flowLayoutPanelMembers.Top = labelDescription.Bottom + 20; 



            btnClose.Text = "Exit";
            // Thêm thông tin từng thành viên
            AddMember("Nguyễn Kinh Quốc", "...", "Phụ trách thiết kế About us.");
            AddMember("Trần Công Hoàng Tấn", "...", "....");
            AddMember("Trần Nguyễn Duy Thịnh", "...", "....");
            AddMember("Huỳnh Gia Khang", "...", "....");
            AddMember("Trương Tấn Dũng", "...", "....");
            labelDescription.MaximumSize = new Size((int)(this.ClientSize.Width * 0.8), 0);
            labelDescription.AutoSize = true;
            CenterSocialLinks();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(LLFacebook, "Facebook của nhóm");
            tip.SetToolTip(LLGitHub, "GitHub của nhóm");
        }

        private void AddMember(string name, string role, string description)
        {
            Label lbl = new Label();
            lbl.Text = $"{name} - {role}\n{description}";
            lbl.AutoSize = true;
            lbl.Margin = new Padding(10);
            lbl.Font = new Font("Segoe UI", 9);
            flowLayoutPanelMembers.Controls.Add(lbl); // flowLayoutPanelMembers đã có sẵn trong Form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CenterLabel(Label lbl)
        {
            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
        }

        private void CenterExitButton()
        {
            // Căn giữa theo chiều ngang
            btnClose.Left = (this.ClientSize.Width - btnClose.Width) / 2;

            // Đặt ở dưới cùng cách đáy 20px
            btnClose.Top = this.ClientSize.Height - btnClose.Height - 20;
        }

        private void CenterFlowLayoutPanel()
        {
            int targetWidth = (int)(this.ClientSize.Width * 0.8);
            flowLayoutPanelMembers.Width = targetWidth;

            // Đặt chiều cao hợp lý
            flowLayoutPanelMembers.Height = 180; // hoặc tùy chỉnh

            flowLayoutPanelMembers.Left = (this.ClientSize.Width - targetWidth) / 2;

            // Căn phía dưới labelDescription
            flowLayoutPanelMembers.Top = labelDescription.Bottom + 20; // cách 20px
        }

        private void LLFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/khang.huynh.630954",
                UseShellExecute = true
            });
        }

        private void LLGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/n0thing2c",
                UseShellExecute = true
            });
        }
        private void AboutUsForm_Resize(object sender, EventArgs e)
        {
            CenterExitButton();
            CenterFlowLayoutPanel();
            CenterLabel(labelTitle);
            CenterLabel(labelDescription);
            CenterSocialLinks();
        }
        private void CenterSocialLinks()
        {
            int spacing = 20;
            int totalWidth = LLFacebook.Width + spacing + LLGitHub.Width;

            int startX = (this.ClientSize.Width - totalWidth) / 2;

            LLFacebook.Left = startX;
            LLGitHub.Left = LLFacebook.Right + spacing;

            // Nằm sát đáy: đặt TOP phía trên nút Exit 5px
            int linkTop = this.ClientSize.Height - btnClose.Height - LLFacebook.Height - 20;

            LLFacebook.Top = LLGitHub.Top = linkTop;
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
