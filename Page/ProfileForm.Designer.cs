namespace Login.Page
{
    partial class ProfileForm
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
            this.Show_Pass_Button = new System.Windows.Forms.Button();
            this.Show_Username_Button = new System.Windows.Forms.Button();
            this.pass_label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Return_Click = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show_Pass_Button
            // 
            this.Show_Pass_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Show_Pass_Button.Location = new System.Drawing.Point(132, 223);
            this.Show_Pass_Button.Name = "Show_Pass_Button";
            this.Show_Pass_Button.Size = new System.Drawing.Size(130, 59);
            this.Show_Pass_Button.TabIndex = 3;
            this.Show_Pass_Button.Text = "Click for Pass";
            this.Show_Pass_Button.UseVisualStyleBackColor = true;
            this.Show_Pass_Button.Click += new System.EventHandler(this.Show_Username_Button_Click);
            // 
            // Show_Username_Button
            // 
            this.Show_Username_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Show_Username_Button.Location = new System.Drawing.Point(132, 90);
            this.Show_Username_Button.Name = "Show_Username_Button";
            this.Show_Username_Button.Size = new System.Drawing.Size(130, 55);
            this.Show_Username_Button.TabIndex = 4;
            this.Show_Username_Button.Text = "Click for UserName";
            this.Show_Username_Button.UseVisualStyleBackColor = true;
            this.Show_Username_Button.Click += new System.EventHandler(this.Show_Pass_Button_Click);
            // 
            // pass_label
            // 
            this.pass_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(350, 244);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(67, 16);
            this.pass_label.TabIndex = 5;
            this.pass_label.Text = "Password";
            this.pass_label.Click += new System.EventHandler(this.pass_label_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(393, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 59);
            this.button4.TabIndex = 6;
            this.button4.Text = "Change password";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Return_Click
            // 
            this.Return_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Return_Click.Location = new System.Drawing.Point(132, 369);
            this.Return_Click.Name = "Return_Click";
            this.Return_Click.Size = new System.Drawing.Size(115, 59);
            this.Return_Click.TabIndex = 11;
            this.Return_Click.Text = "Return";
            this.Return_Click.UseVisualStyleBackColor = true;
            this.Return_Click.Click += new System.EventHandler(this.Return_Click_Click);
            // 
            // user_label
            // 
            this.user_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(347, 109);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(70, 16);
            this.user_label.TabIndex = 12;
            this.user_label.Text = "Username";
            this.user_label.Click += new System.EventHandler(this.user_label_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 533);
            this.ControlBox = false;
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.Return_Click);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.Show_Username_Button);
            this.Controls.Add(this.Show_Pass_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show_Pass_Button;
        private System.Windows.Forms.Button Show_Username_Button;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Return_Click;
        private System.Windows.Forms.Label user_label;
    }
}