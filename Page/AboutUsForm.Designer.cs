using System.Drawing;
using System.Windows.Forms;

namespace Login.Page
{
    partial class AboutUsForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.LBProject1 = new System.Windows.Forms.Label();
            this.LBProject2 = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.flowLayoutPanelMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.LLGitHub = new System.Windows.Forms.LinkLabel();
            this.LLFacebook = new System.Windows.Forms.LinkLabel();
            this.BodyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(144)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(751, 61);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ABOUT US";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBProject1
            // 
            this.LBProject1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBProject1.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBProject1.ForeColor = System.Drawing.Color.Black;
            this.LBProject1.Location = new System.Drawing.Point(0, 0);
            this.LBProject1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBProject1.Name = "LBProject1";
            this.LBProject1.Size = new System.Drawing.Size(751, 50);
            this.LBProject1.TabIndex = 1;
            this.LBProject1.Text = "EXPENSE APP PROJECT";
            this.LBProject1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LBProject2
            // 
            this.LBProject2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBProject2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBProject2.ForeColor = System.Drawing.Color.Black;
            this.LBProject2.Location = new System.Drawing.Point(0, 50);
            this.LBProject2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBProject2.Name = "LBProject2";
            this.LBProject2.Size = new System.Drawing.Size(751, 33);
            this.LBProject2.TabIndex = 8;
            this.LBProject2.Text = "LAB PROJECT - OOP";
            this.LBProject2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BodyPanel
            // 
            this.BodyPanel.AutoScroll = true;
            this.BodyPanel.Controls.Add(this.panel1);
            this.BodyPanel.Controls.Add(this.LBProject2);
            this.BodyPanel.Controls.Add(this.LBProject1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Enabled = false;
            this.BodyPanel.Location = new System.Drawing.Point(0, 61);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(751, 456);
            this.BodyPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.flowLayoutPanelMembers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 373);
            this.panel1.TabIndex = 9;
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDescription.Location = new System.Drawing.Point(0, 0);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(751, 53);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Đây là ứng dụng quản lý...., hỗ trợ thêm, sửa, xoá";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelMembers
            // 
            this.flowLayoutPanelMembers.AutoScroll = true;
            this.flowLayoutPanelMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelMembers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMembers.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanelMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelMembers.Name = "flowLayoutPanelMembers";
            this.flowLayoutPanelMembers.Size = new System.Drawing.Size(751, 315);
            this.flowLayoutPanelMembers.TabIndex = 2;
            this.flowLayoutPanelMembers.WrapContents = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.FooterPanel.Controls.Add(this.btnClose);
            this.FooterPanel.Controls.Add(this.LLGitHub);
            this.FooterPanel.Controls.Add(this.LLFacebook);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 517);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(751, 65);
            this.FooterPanel.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(303, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LLGitHub
            // 
            this.LLGitHub.AutoSize = true;
            this.LLGitHub.Location = new System.Drawing.Point(112, 26);
            this.LLGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLGitHub.Name = "LLGitHub";
            this.LLGitHub.Size = new System.Drawing.Size(71, 25);
            this.LLGitHub.TabIndex = 7;
            this.LLGitHub.TabStop = true;
            this.LLGitHub.Text = "GitHub";
            this.LLGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLGitHub_LinkClicked);
            // 
            // LLFacebook
            // 
            this.LLFacebook.AutoSize = true;
            this.LLFacebook.Location = new System.Drawing.Point(13, 26);
            this.LLFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLFacebook.Name = "LLFacebook";
            this.LLFacebook.Size = new System.Drawing.Size(91, 25);
            this.LLFacebook.TabIndex = 5;
            this.LLFacebook.TabStop = true;
            this.LLFacebook.Text = "Facebook";
            this.LLFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLFacebook_LinkClicked);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(751, 582);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            this.BodyPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LBProject1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMembers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel LLFacebook;
        private System.Windows.Forms.LinkLabel LLGitHub;
        private System.Windows.Forms.Label labelDescription;
        private Panel BodyPanel;
        private Panel FooterPanel;
        private Label LBProject2;
        private Panel panel1;
    }
}