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
            this.labelProject = new System.Windows.Forms.Label();
            this.flowLayoutPanelMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.LLFacebook = new System.Windows.Forms.LinkLabel();
            this.LLGitHub = new System.Windows.Forms.LinkLabel();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Pink;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1120, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProject
            // 
            this.labelProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProject.ForeColor = System.Drawing.Color.Navy;
            this.labelProject.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelProject.Location = new System.Drawing.Point(0, 70);
            this.labelProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(1120, 25);
            this.labelProject.TabIndex = 1;
            this.labelProject.Text = "labelProject";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelMembers
            // 
            this.flowLayoutPanelMembers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMembers.Location = new System.Drawing.Point(0, 208);
            this.flowLayoutPanelMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelMembers.Name = "flowLayoutPanelMembers";
            this.flowLayoutPanelMembers.Size = new System.Drawing.Size(255, 200);
            this.flowLayoutPanelMembers.TabIndex = 2;
            this.flowLayoutPanelMembers.WrapContents = false;
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGroup.BackgroundImage = global::Login.Properties.Resources.bank_pig;
            this.pictureBoxGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGroup.ErrorImage = global::Login.Properties.Resources.bank_pig;
            this.pictureBoxGroup.Location = new System.Drawing.Point(0, 55);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(125, 78);
            this.pictureBoxGroup.TabIndex = 3;
            this.pictureBoxGroup.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 468);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LLFacebook
            // 
            this.LLFacebook.AutoSize = true;
            this.LLFacebook.Location = new System.Drawing.Point(-1, 413);
            this.LLFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLFacebook.Name = "LLFacebook";
            this.LLFacebook.Size = new System.Drawing.Size(91, 25);
            this.LLFacebook.TabIndex = 5;
            this.LLFacebook.TabStop = true;
            this.LLFacebook.Text = "Facebook";
            this.LLFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLFacebook_LinkClicked);
            // 
            // LLGitHub
            // 
            this.LLGitHub.AutoSize = true;
            this.LLGitHub.Location = new System.Drawing.Point(2, 438);
            this.LLGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLGitHub.Name = "LLGitHub";
            this.LLGitHub.Size = new System.Drawing.Size(71, 25);
            this.LLGitHub.TabIndex = 7;
            this.LLGitHub.TabStop = true;
            this.LLGitHub.Text = "GitHub";
            this.LLGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLGitHub_LinkClicked);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDescription.Location = new System.Drawing.Point(0, 162);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(132, 23);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "labelDescription";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 703);
            this.Controls.Add(this.LLGitHub);
            this.Controls.Add(this.LLFacebook);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutPanelMembers);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMembers;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel LLFacebook;
        private System.Windows.Forms.LinkLabel LLGitHub;
        private System.Windows.Forms.Label labelDescription;
    }
}