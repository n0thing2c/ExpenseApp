namespace Login.Page
{
    partial class ReportForm
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
            this.usercontact = new System.Windows.Forms.TextBox();
            this.report_bug_label = new System.Windows.Forms.Label();
            this.bug_des_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.bugtextbox = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usercontact
            // 
            this.usercontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontact.Location = new System.Drawing.Point(223, 134);
            this.usercontact.Name = "usercontact";
            this.usercontact.Size = new System.Drawing.Size(331, 30);
            this.usercontact.TabIndex = 0;
            // 
            // report_bug_label
            // 
            this.report_bug_label.AutoSize = true;
            this.report_bug_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_bug_label.ForeColor = System.Drawing.Color.White;
            this.report_bug_label.Location = new System.Drawing.Point(158, 22);
            this.report_bug_label.Name = "report_bug_label";
            this.report_bug_label.Size = new System.Drawing.Size(293, 38);
            this.report_bug_label.TabIndex = 1;
            this.report_bug_label.Text = "🐞 Report a Bug 🐞";
            // 
            // bug_des_label
            // 
            this.bug_des_label.AutoSize = true;
            this.bug_des_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bug_des_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(149)))));
            this.bug_des_label.Location = new System.Drawing.Point(50, 190);
            this.bug_des_label.Name = "bug_des_label";
            this.bug_des_label.Size = new System.Drawing.Size(155, 25);
            this.bug_des_label.TabIndex = 2;
            this.bug_des_label.Text = "Bug Description:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(149)))));
            this.email_label.Location = new System.Drawing.Point(50, 136);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(157, 25);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "Your Contact     :";
            // 
            // bugtextbox
            // 
            this.bugtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bugtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugtextbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bugtextbox.Location = new System.Drawing.Point(55, 228);
            this.bugtextbox.Multiline = true;
            this.bugtextbox.Name = "bugtextbox";
            this.bugtextbox.Size = new System.Drawing.Size(499, 205);
            this.bugtextbox.TabIndex = 4;
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.LightCoral;
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Location = new System.Drawing.Point(369, 449);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(81, 36);
            this.return_button.TabIndex = 5;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Black;
            this.save_button.Location = new System.Drawing.Point(473, 449);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(81, 36);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Send";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.report_bug_label);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 80);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(174, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.bugtextbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.bug_des_label);
            this.Controls.Add(this.usercontact);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usercontact;
        private System.Windows.Forms.Label report_bug_label;
        private System.Windows.Forms.Label bug_des_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox bugtextbox;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}