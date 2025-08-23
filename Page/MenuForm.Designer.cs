using System.Drawing;
using System.IO;
using System;
using System.Windows.Forms;
namespace Login.Page
{
    partial class MenuForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotificationList_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.User_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Reports_Button = new System.Windows.Forms.Button();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.DrawChart_button = new System.Windows.Forms.Button();
            this.AboutUs_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.NewFile_Button = new System.Windows.Forms.Button();
            this.PickFile_Button = new System.Windows.Forms.Button();
            this.Notification_Button = new System.Windows.Forms.Button();
            this.Personal_Button = new System.Windows.Forms.Button();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.gif = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.User_Panel.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.Notification_Button);
            this.panel1.Controls.Add(this.Personal_Button);
            this.panel1.Controls.Add(this.Menu_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.DrawChart_button);
            this.panel2.Controls.Add(this.AboutUs_Button);
            this.panel2.Controls.Add(this.Exit_Button);
            this.panel2.Controls.Add(this.NewFile_Button);
            this.panel2.Controls.Add(this.PickFile_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 571);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // NotificationList_panel
            // 
            this.NotificationList_panel.BackColor = System.Drawing.Color.White;
            this.NotificationList_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationList_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NotificationList_panel.Location = new System.Drawing.Point(810, 83);
            this.NotificationList_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NotificationList_panel.Name = "NotificationList_panel";
            this.NotificationList_panel.Size = new System.Drawing.Size(197, 283);
            this.NotificationList_panel.TabIndex = 2;
            this.NotificationList_panel.Visible = false;
            // 
            // User_Panel
            // 
            this.User_Panel.BackColor = System.Drawing.Color.White;
            this.User_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Panel.Controls.Add(this.Profile_Button);
            this.User_Panel.Controls.Add(this.Reports_Button);
            this.User_Panel.Controls.Add(this.LogOut_Button);
            this.User_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.User_Panel.Location = new System.Drawing.Point(924, 83);
            this.User_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_Panel.Name = "User_Panel";
            this.User_Panel.Size = new System.Drawing.Size(98, 143);
            this.User_Panel.TabIndex = 3;
            this.User_Panel.Visible = false;
            // 
            // Profile_Button
            // 
            this.Profile_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Button.Location = new System.Drawing.Point(2, 2);
            this.Profile_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(90, 63);
            this.Profile_Button.TabIndex = 0;
            this.Profile_Button.Text = "Change Password";
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Reports_Button
            // 
            this.Reports_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_Button.Location = new System.Drawing.Point(2, 69);
            this.Reports_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reports_Button.Name = "Reports_Button";
            this.Reports_Button.Size = new System.Drawing.Size(90, 30);
            this.Reports_Button.TabIndex = 2;
            this.Reports_Button.Text = "Reports";
            this.Reports_Button.UseVisualStyleBackColor = true;
            this.Reports_Button.Click += new System.EventHandler(this.Reports_Button_Click);
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(2, 103);
            this.LogOut_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(90, 30);
            this.LogOut_Button.TabIndex = 3;
            this.LogOut_Button.Text = "Log out";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.gif);
            this.panelContent.Location = new System.Drawing.Point(0, 69);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1031, 575);
            this.panelContent.TabIndex = 4;
            this.panelContent.Click += new System.EventHandler(this.panelContent_Click);
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // DrawChart_button
            // 
            this.DrawChart_button.FlatAppearance.BorderSize = 0;
            this.DrawChart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawChart_button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawChart_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(9)))));
            this.DrawChart_button.Image = global::Login.Properties.Resources.pie;
            this.DrawChart_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DrawChart_button.Location = new System.Drawing.Point(10, 235);
            this.DrawChart_button.Margin = new System.Windows.Forms.Padding(2);
            this.DrawChart_button.Name = "DrawChart_button";
            this.DrawChart_button.Size = new System.Drawing.Size(235, 45);
            this.DrawChart_button.TabIndex = 9;
            this.DrawChart_button.Text = "Draw Chart";
            this.DrawChart_button.UseVisualStyleBackColor = true;
            this.DrawChart_button.Click += new System.EventHandler(this.DrawChart_button_Click);
            // 
            // AboutUs_Button
            // 
            this.AboutUs_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.AboutUs_Button.FlatAppearance.BorderSize = 0;
            this.AboutUs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUs_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUs_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(9)))));
            this.AboutUs_Button.Image = ((System.Drawing.Image)(resources.GetObject("AboutUs_Button.Image")));
            this.AboutUs_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutUs_Button.Location = new System.Drawing.Point(12, 303);
            this.AboutUs_Button.Name = "AboutUs_Button";
            this.AboutUs_Button.Size = new System.Drawing.Size(237, 55);
            this.AboutUs_Button.TabIndex = 8;
            this.AboutUs_Button.Text = "About us";
            this.AboutUs_Button.UseVisualStyleBackColor = true;
            this.AboutUs_Button.Visible = false;
            this.AboutUs_Button.Click += new System.EventHandler(this.AboutUs_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.LightPink;
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.Location = new System.Drawing.Point(10, 495);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(205, 55);
            this.Exit_Button.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Exit_Button, "Exit");
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Visible = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // NewFile_Button
            // 
            this.NewFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.NewFile_Button.FlatAppearance.BorderSize = 0;
            this.NewFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFile_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFile_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(9)))));
            this.NewFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("NewFile_Button.Image")));
            this.NewFile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewFile_Button.Location = new System.Drawing.Point(10, 85);
            this.NewFile_Button.Name = "NewFile_Button";
            this.NewFile_Button.Size = new System.Drawing.Size(237, 55);
            this.NewFile_Button.TabIndex = 6;
            this.NewFile_Button.Text = "New File";
            this.NewFile_Button.UseVisualStyleBackColor = true;
            this.NewFile_Button.Visible = false;
            this.NewFile_Button.Click += new System.EventHandler(this.NewFile_Button_Click);
            // 
            // PickFile_Button
            // 
            this.PickFile_Button.FlatAppearance.BorderSize = 0;
            this.PickFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickFile_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickFile_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(9)))));
            this.PickFile_Button.Image = global::Login.Properties.Resources.file;
            this.PickFile_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PickFile_Button.Location = new System.Drawing.Point(10, 157);
            this.PickFile_Button.Name = "PickFile_Button";
            this.PickFile_Button.Size = new System.Drawing.Size(237, 55);
            this.PickFile_Button.TabIndex = 11;
            this.PickFile_Button.Text = "Pick File";
            this.PickFile_Button.Click += new System.EventHandler(this.PickFile_Button_Click);
            // 
            // Notification_Button
            // 
            this.Notification_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.Notification_Button.FlatAppearance.BorderSize = 0;
            this.Notification_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_Button.ForeColor = System.Drawing.Color.LightPink;
            this.Notification_Button.Image = global::Login.Properties.Resources.Layer_0;
            this.Notification_Button.Location = new System.Drawing.Point(909, 11);
            this.Notification_Button.Name = "Notification_Button";
            this.Notification_Button.Size = new System.Drawing.Size(53, 55);
            this.Notification_Button.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Notification_Button, "Notifications");
            this.Notification_Button.UseVisualStyleBackColor = true;
            this.Notification_Button.Click += new System.EventHandler(this.Notification_Button_Click);
            // 
            // Personal_Button
            // 
            this.Personal_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.Personal_Button.FlatAppearance.BorderSize = 0;
            this.Personal_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal_Button.ForeColor = System.Drawing.Color.LightPink;
            this.Personal_Button.Image = global::Login.Properties.Resources.pro5;
            this.Personal_Button.Location = new System.Drawing.Point(968, 11);
            this.Personal_Button.Name = "Personal_Button";
            this.Personal_Button.Size = new System.Drawing.Size(53, 55);
            this.Personal_Button.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Personal_Button, "User");
            this.Personal_Button.UseVisualStyleBackColor = true;
            this.Personal_Button.Click += new System.EventHandler(this.Personal_Button_Click);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.Menu_Button.FlatAppearance.BorderSize = 0;
            this.Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Button.Image")));
            this.Menu_Button.Location = new System.Drawing.Point(202, 11);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(57, 45);
            this.Menu_Button.TabIndex = 1;
            this.Menu_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.Menu_Button, "Menu");
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // gif
            // 
            this.gif.Image = global::Login.Properties.Resources.giphy;
            this.gif.Location = new System.Drawing.Point(411, 0);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(394, 358);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1031, 640);
            this.Controls.Add(this.User_Panel);
            this.Controls.Add(this.NotificationList_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.User_Panel.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button Menu_Button;
        private Button Personal_Button;
        private Button Notification_Button;
        private Button NewFile_Button;
        private Button PickFile_Button;
        private Button Exit_Button;
        private FlowLayoutPanel NotificationList_panel;
        private Button AboutUs_Button;
        private ToolTip toolTip1;
        private FlowLayoutPanel User_Panel;
        private Button Profile_Button;
        private Button Reports_Button;
        private Button LogOut_Button;
        private Panel panelContent;
        private Button DrawChart_button;
        private PictureBox gif;
    }
}