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
            this.add = new System.Windows.Forms.PictureBox();
            this.account = new System.Windows.Forms.PictureBox();
            this.accountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountButton);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Location = new System.Drawing.Point(229, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // add
            // 
            this.add.Image = global::Login.Properties.Resources.plus2;
            this.add.Location = new System.Drawing.Point(21, 91);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(35, 35);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            // 
            // account
            // 
            this.account.Image = global::Login.Properties.Resources.pro5_icon;
            this.account.Location = new System.Drawing.Point(21, 19);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(35, 35);
            this.account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.account.TabIndex = 0;
            this.account.TabStop = false;
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.Salmon;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.Location = new System.Drawing.Point(62, 19);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(210, 35);
            this.accountButton.TabIndex = 1;
            this.accountButton.Text = "View Account";
            this.accountButton.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox account;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.Button accountButton;
    }
}