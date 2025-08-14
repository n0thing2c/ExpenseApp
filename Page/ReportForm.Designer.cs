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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.report_bug_label = new System.Windows.Forms.Label();
            this.bug_des_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 0;
            // 
            // report_bug_label
            // 
            this.report_bug_label.AutoSize = true;
            this.report_bug_label.Font = new System.Drawing.Font("Franklin Gothic Heavy", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_bug_label.ForeColor = System.Drawing.Color.Salmon;
            this.report_bug_label.Location = new System.Drawing.Point(190, 27);
            this.report_bug_label.Name = "report_bug_label";
            this.report_bug_label.Size = new System.Drawing.Size(340, 43);
            this.report_bug_label.TabIndex = 1;
            this.report_bug_label.Text = "🐞 Report a Bug 🐞";
            this.report_bug_label.Click += new System.EventHandler(this.report_bug_label_Click);
            // 
            // bug_des_label
            // 
            this.bug_des_label.AutoSize = true;
            this.bug_des_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bug_des_label.Location = new System.Drawing.Point(127, 233);
            this.bug_des_label.Name = "bug_des_label";
            this.bug_des_label.Size = new System.Drawing.Size(139, 22);
            this.bug_des_label.TabIndex = 2;
            this.bug_des_label.Text = "Bug Description";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(141, 123);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(100, 22);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "Your Email";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(295, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 4;
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(217, 326);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 5;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(382, 326);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.bug_des_label);
            this.Controls.Add(this.report_bug_label);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label report_bug_label;
        private System.Windows.Forms.Label bug_des_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button save_button;
    }
}