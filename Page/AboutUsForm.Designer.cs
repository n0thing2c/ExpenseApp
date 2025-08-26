using System.Drawing;
using System.Windows.Forms;

namespace Login.Page
{
    partial class AboutUsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.LBProject1 = new System.Windows.Forms.Label();
            this.LBProject2 = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMembers = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_RTBDescription = new System.Windows.Forms.Panel();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.LLGitHub = new System.Windows.Forms.LinkLabel();
            this.BodyPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.Panel_RTBDescription.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(144)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 98);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ABOUT US";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBProject1
            // 
            this.LBProject1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBProject1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.LBProject1.ForeColor = System.Drawing.Color.Black;
            this.LBProject1.Location = new System.Drawing.Point(0, 0);
            this.LBProject1.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.LBProject1.Name = "LBProject1";
            this.LBProject1.Size = new System.Drawing.Size(800, 50);
            this.LBProject1.TabIndex = 1;
            this.LBProject1.Text = "EXPENSE APP PROJECT";
            this.LBProject1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LBProject2
            // 
            this.LBProject2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBProject2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LBProject2.ForeColor = System.Drawing.Color.Black;
            this.LBProject2.Location = new System.Drawing.Point(0, 50);
            this.LBProject2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.LBProject2.Name = "LBProject2";
            this.LBProject2.Size = new System.Drawing.Size(800, 30);
            this.LBProject2.TabIndex = 8;
            this.LBProject2.Text = "LAB PROJECT - OOP";
            this.LBProject2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BodyPanel
            // 
            this.BodyPanel.AutoScroll = true;
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.ContentPanel);
            this.BodyPanel.Controls.Add(this.LBProject2);
            this.BodyPanel.Controls.Add(this.LBProject1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 98);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 437);
            this.BodyPanel.TabIndex = 8;
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.Controls.Add(this.tableLayoutPanelMembers);
            this.ContentPanel.Controls.Add(this.Panel_RTBDescription);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentPanel.Location = new System.Drawing.Point(0, 80);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(800, 27);
            this.ContentPanel.TabIndex = 9;
            // 
            // tableLayoutPanelMembers
            // 
            this.tableLayoutPanelMembers.AutoSize = true;
            this.tableLayoutPanelMembers.ColumnCount = 3;
            this.tableLayoutPanelMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMembers.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanelMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelMembers.Name = "tableLayoutPanelMembers";
            this.tableLayoutPanelMembers.Size = new System.Drawing.Size(800, 0);
            this.tableLayoutPanelMembers.TabIndex = 8;
            // 
            // Panel_RTBDescription
            // 
            this.Panel_RTBDescription.Controls.Add(this.RTBDescription);
            this.Panel_RTBDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_RTBDescription.Location = new System.Drawing.Point(0, 0);
            this.Panel_RTBDescription.Name = "Panel_RTBDescription";
            this.Panel_RTBDescription.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Panel_RTBDescription.Size = new System.Drawing.Size(800, 27);
            this.Panel_RTBDescription.TabIndex = 9;
            // 
            // RTBDescription
            // 
            this.RTBDescription.BackColor = System.Drawing.Color.White;
            this.RTBDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTBDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBDescription.Location = new System.Drawing.Point(50, 0);
            this.RTBDescription.Margin = new System.Windows.Forms.Padding(0);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.ReadOnly = true;
            this.RTBDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTBDescription.Size = new System.Drawing.Size(700, 27);
            this.RTBDescription.TabIndex = 0;
            this.RTBDescription.Text = resources.GetString("RTBDescription.Text");
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.FooterPanel.Controls.Add(this.btnClose);
            this.FooterPanel.Controls.Add(this.LLGitHub);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 535);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(800, 65);
            this.FooterPanel.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(721, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // LLGitHub
            // 
            this.LLGitHub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.LLGitHub.AutoSize = true;
            this.LLGitHub.DisabledLinkColor = System.Drawing.Color.Black;
            this.LLGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LLGitHub.Location = new System.Drawing.Point(26, 26);
            this.LLGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLGitHub.Name = "LLGitHub";
            this.LLGitHub.Size = new System.Drawing.Size(71, 25);
            this.LLGitHub.TabIndex = 7;
            this.LLGitHub.TabStop = true;
            this.LLGitHub.Text = "GitHub";
            this.LLGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLGitHub_LinkClicked);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.Panel_RTBDescription.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Windows Form Designer generated code
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LBProject1;
        private System.Windows.Forms.Label LBProject2;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMembers;
        private System.Windows.Forms.Panel Panel_RTBDescription;
        private System.Windows.Forms.RichTextBox RTBDescription;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel LLGitHub;
        #endregion
    }
}