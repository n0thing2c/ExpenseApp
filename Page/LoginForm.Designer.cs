using System.Drawing;
using System.IO;
using System;
using System.Windows.Forms;
namespace Login.Page
{
    partial class LoginForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.pig = new System.Windows.Forms.PictureBox();
            this.openEye = new System.Windows.Forms.PictureBox();
            this.closeEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeEye)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Salmon;
            this.Label1.Location = new System.Drawing.Point(123, 133);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 47);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "LOGIN";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Firebrick;
            this.Panel1.Location = new System.Drawing.Point(35, 254);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(315, 1);
            this.Panel1.TabIndex = 3;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Firebrick;
            this.Panel2.Location = new System.Drawing.Point(35, 340);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(315, 1);
            this.Panel2.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Salmon;
            this.Exit.Location = new System.Drawing.Point(163, 481);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(48, 25);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(65, 443);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(178, 21);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Don\'t have an account?";
            // 
            // signUpButton
            // 
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.Tomato;
            this.signUpButton.Location = new System.Drawing.Point(241, 437);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(93, 33);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Salmon;
            this.txtUsername.Location = new System.Drawing.Point(77, 218);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(272, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Salmon;
            this.txtPassword.Location = new System.Drawing.Point(76, 303);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(272, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Salmon;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(35, 380);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(315, 41);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.Login_Button);
            // 
            // userIcon
            // 
            this.userIcon.Image = global::Login.Properties.Resources.pro5_icon;
            this.userIcon.Location = new System.Drawing.Point(35, 215);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(33, 31);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 10;
            this.userIcon.TabStop = false;
            // 
            // passIcon
            // 
            this.passIcon.Image = global::Login.Properties.Resources.lock_icon2;
            this.passIcon.Location = new System.Drawing.Point(35, 302);
            this.passIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(33, 31);
            this.passIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passIcon.TabIndex = 10;
            this.passIcon.TabStop = false;
            // 
            // pig
            // 
            this.pig.Image = global::Login.Properties.Resources.bank_pig;
            this.pig.Location = new System.Drawing.Point(132, 12);
            this.pig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pig.Name = "pig";
            this.pig.Size = new System.Drawing.Size(116, 87);
            this.pig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pig.TabIndex = 9;
            this.pig.TabStop = false;
            // 
            // openEye
            // 
            this.openEye.Image = global::Login.Properties.Resources.open_eye;
            this.openEye.Location = new System.Drawing.Point(316, 302);
            this.openEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openEye.Name = "openEye";
            this.openEye.Size = new System.Drawing.Size(33, 31);
            this.openEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openEye.TabIndex = 11;
            this.openEye.TabStop = false;
            this.openEye.Click += new System.EventHandler(this.openEye_Click);
            // 
            // closeEye
            // 
            this.closeEye.Image = global::Login.Properties.Resources.close_eye1;
            this.closeEye.Location = new System.Drawing.Point(315, 302);
            this.closeEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeEye.Name = "closeEye";
            this.closeEye.Size = new System.Drawing.Size(33, 31);
            this.closeEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeEye.TabIndex = 11;
            this.closeEye.TabStop = false;
            this.closeEye.Click += new System.EventHandler(this.closeEye_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 550);
            this.Controls.Add(this.closeEye);
            this.Controls.Add(this.openEye);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.pig);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox pig;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox openEye;
        private System.Windows.Forms.PictureBox closeEye;
    }
}
