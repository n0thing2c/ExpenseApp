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

            // Tính chiều cao động cho RTBDescription
            int lastCharIndex = RTBDescription.TextLength;
            int y = RTBDescription.GetPositionFromCharIndex(lastCharIndex).Y;
            int neededHeight = y + RTBDescription.Font.Height + 50;
            RTBDescription.Height = neededHeight;
            Panel_RTBDescription.Height = neededHeight;

            LoadTeamInfo();
            this.MouseDown += Form_MouseDown;
            CenterExitButton();

            // Thêm sự kiện MouseWheel để cuộn BodyPanel
            RTBDescription.MouseWheel += RTBDescription_MouseWheel;

            // Thêm sự kiện GotFocus để ẩn con trỏ chỉnh sửa
            RTBDescription.GotFocus += RTBDescription_GotFocus;

            // Cho phép copy văn bản
            RTBDescription.ShortcutsEnabled = true;

            // Thêm sự kiện hover cho btnClose
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;

            // Cập nhật kích thước và layout
            UpdateContentPanelSize();

            Debug.WriteLine("Total body content height: " + BodyPanel.DisplayRectangle.Height);
            Debug.WriteLine("Client height: " + BodyPanel.ClientSize.Height);
        }

        private void LoadTeamInfo()
        {
            // Suspend layout để tối ưu
            tableLayoutPanelMembers.SuspendLayout();
            ContentPanel.SuspendLayout();
            BodyPanel.SuspendLayout();

            // Dữ liệu thành viên
            var members = new List<(string Name, string StudentID, string Role, string Description)>
            {
                ("Huỳnh Gia Khang", "24127179", "-Developer\n-Report writer", "-Design classes for file handling\n-Design UI, flow chart and logics for Management windows\n-Write report, design UML"),
                ("Trần Nguyễn Duy Thịnh", "24127126", "-Developer\n-Report writer", "-Design classes for user account handling.\n-Design App’s theme color, UI, flow chart and logic for Login/Sign up windows and Draw Chart windows\n-Write report, design UML"),
                ("Trương Tấn Dũng", "24127026", "-Interface and system designer\n-Video creator\n-Flow chart design", "-Design system structure, flow chart and GUI for the Menu\n-Record Expense App tutorial video"),
                ("Trần Công Hoàng Tấn", "24127237", "-Developer\n-Flow chart designer", "-Design UI, flow chart and logics for Reports and Profile windows"),
                ("Nguyễn Kinh Quốc", "24127230", "-Developer\n-Flow chart designer", "-Design UI and logics for the About Us window")
            };

            // Thiết lập số hàng cho TableLayoutPanel
            int rowCount = (int)Math.Ceiling(members.Count / 3.0);
            tableLayoutPanelMembers.RowCount = rowCount;
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanelMembers.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            ToolTip tip = new ToolTip();
            int index = 0;
            foreach (var member in members)
            {
                int row = index / 3;
                int col = index % 3;
                AddMember(member.Name, member.StudentID, member.Role, member.Description, tip, row, col);
                index++;
            }
            tip.SetToolTip(LLGitHub, "Team's GitHub");

            // Cập nhật chiều cao đồng đều cho MemberPanel trong cùng hàng
            for (int row = 0; row < rowCount; row++)
            {
                int maxHeight = 0;
                for (int col = 0; col < 3; col++)
                {
                    var control = tableLayoutPanelMembers.GetControlFromPosition(col, row);
                    if (control != null)
                    {
                        maxHeight = Math.Max(maxHeight, control.Height);
                    }
                }
                for (int col = 0; col < 3; col++)
                {
                    var control = tableLayoutPanelMembers.GetControlFromPosition(col, row);
                    if (control != null)
                    {
                        control.Height = maxHeight;
                    }
                }
            }

            // Resume layout
            tableLayoutPanelMembers.ResumeLayout(true);
            ContentPanel.ResumeLayout(true);
            BodyPanel.ResumeLayout(true);
        }

        private void AddMember(string name, string studentID, string role, string description, ToolTip tip, int row, int col)
        {
            // Tạo Panel cho mỗi thành viên
            Panel memberPanel = new Panel
            {
                Width = 250, // Tăng chiều rộng để chứa văn bản dài
                AutoSize = false, // Tắt AutoSize để cố định Width, Height sẽ set sau
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(240, 240, 255)
            };

            // Tạo TableLayoutPanel để sắp xếp thông tin
            TableLayoutPanel layout = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 1,
                RowCount = 4, // 4 hàng: Name, Student ID, Team role, Description
                Dock = DockStyle.Top,
                Padding = new Padding(5)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Label cho tên
            Label lblName = new Label
            {
                Text = name,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black
            };
            layout.Controls.Add(lblName, 0, 0);

            // Label cho Student ID
            Label lblStudentID = new Label
            {
                Text = $"Student ID: {studentID}",
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Black
            };
            layout.Controls.Add(lblStudentID, 0, 1);

            // Label cho Team role
            Label lblRole = new Label
            {
                Text = $"Role:\n{role}",
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Black
            };
            layout.Controls.Add(lblRole, 0, 2);

            // Label cho Description
            Label lblDescription = new Label
            {
                Text = $"Description:\n{description}",
                AutoSize = true,
                MaximumSize = new Size(220, 0), // Giới hạn chiều rộng, cho phép wrap
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Black
            };
            layout.Controls.Add(lblDescription, 0, 3);

            // Thêm tooltip
            tip.SetToolTip(memberPanel, $"{name} ({studentID}): {role}, {description}");

            memberPanel.Controls.Add(layout);
            tableLayoutPanelMembers.Controls.Add(memberPanel, col, row);

            // Tính chiều cao sau khi thêm nội dung
            layout.PerformLayout();
            memberPanel.Height = layout.Height + layout.Padding.Top + layout.Padding.Bottom;
        }

        private void UpdateContentPanelSize()
        {
            tableLayoutPanelMembers.PerformLayout();
            int maxRowHeight = 0;
            for (int row = 0; row < tableLayoutPanelMembers.RowCount; row++)
            {
                int rowHeight = 0;
                for (int col = 0; col < 3; col++)
                {
                    var control = tableLayoutPanelMembers.GetControlFromPosition(col, row);
                    if (control != null)
                    {
                        rowHeight = Math.Max(rowHeight, control.Height + control.Margin.Top + control.Margin.Bottom);
                    }
                }
                maxRowHeight += rowHeight;
            }
            tableLayoutPanelMembers.Height = maxRowHeight;
            ContentPanel.Height = Panel_RTBDescription.Height + tableLayoutPanelMembers.Height + ContentPanel.Padding.Top + ContentPanel.Padding.Bottom;
            int totalContentHeight = LBProject1.Height + LBProject2.Height + ContentPanel.Height;
            BodyPanel.AutoScrollMinSize = new Size(0, totalContentHeight);
            BodyPanel.PerformLayout();
            BodyPanel.Invalidate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterExitButton()
        {
            btnClose.Left = (FooterPanel.ClientSize.Width - btnClose.Width) / 2;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 100, 100);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void LLGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/n0thing2c/ExpenseApp",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RTBDescription_MouseWheel(object sender, MouseEventArgs e)
        {
            BodyPanel.Focus();
            int scrollAmount = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            int newScrollValue = BodyPanel.VerticalScroll.Value - scrollAmount * 30;
            newScrollValue = Math.Max(BodyPanel.VerticalScroll.Minimum, Math.Min(newScrollValue, BodyPanel.VerticalScroll.Maximum));
            BodyPanel.VerticalScroll.Value = newScrollValue;
            BodyPanel.PerformLayout();
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void RTBDescription_GotFocus(object sender, EventArgs e)
        {
            BodyPanel.Focus();
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