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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFilePb = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.account = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFilePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.OpenFilePb);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.LoadFileButton);
            this.groupBox1.Controls.Add(this.NewFileButton);
            this.groupBox1.Controls.Add(this.accountButton);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Location = new System.Drawing.Point(316, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(475, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Salmon;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(83, 286);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(280, 43);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.BackColor = System.Drawing.Color.Salmon;
            this.LoadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadFileButton.ForeColor = System.Drawing.Color.White;
            this.LoadFileButton.Location = new System.Drawing.Point(83, 203);
            this.LoadFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(280, 43);
            this.LoadFileButton.TabIndex = 3;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = false;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.BackColor = System.Drawing.Color.Salmon;
            this.NewFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFileButton.ForeColor = System.Drawing.Color.White;
            this.NewFileButton.Location = new System.Drawing.Point(83, 112);
            this.NewFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(280, 43);
            this.NewFileButton.TabIndex = 2;
            this.NewFileButton.Text = "New File";
            this.NewFileButton.UseVisualStyleBackColor = false;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.Salmon;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.Location = new System.Drawing.Point(83, 23);
            this.accountButton.Margin = new System.Windows.Forms.Padding(4);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(280, 43);
            this.accountButton.TabIndex = 1;
            this.accountButton.Text = "View Account";
            this.accountButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login.Properties.Resources.ExitIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(29, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // OpenFilePb
            // 
            this.OpenFilePb.BackgroundImage = global::Login.Properties.Resources.LoadFileIcon;
            this.OpenFilePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFilePb.Location = new System.Drawing.Point(29, 203);
            this.OpenFilePb.Name = "OpenFilePb";
            this.OpenFilePb.Size = new System.Drawing.Size(47, 43);
            this.OpenFilePb.TabIndex = 5;
            this.OpenFilePb.TabStop = false;
            // 
            // add
            // 
            this.add.Image = global::Login.Properties.Resources.plus2;
            this.add.Location = new System.Drawing.Point(28, 112);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(47, 43);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            // 
            // account
            // 
            this.account.Image = global::Login.Properties.Resources.pro5_icon;
            this.account.Location = new System.Drawing.Point(28, 23);
            this.account.Margin = new System.Windows.Forms.Padding(4);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(47, 43);
            this.account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.account.TabIndex = 0;
            this.account.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFilePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox account;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.Button accountButton;
        private Button LoadFileButton;
        private Button NewFileButton;
        private Button ExitButton;
        private PictureBox OpenFilePb;
        private PictureBox pictureBox1;
    }
}