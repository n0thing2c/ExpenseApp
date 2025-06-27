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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Report_Notification = new System.Windows.Forms.Label();
            this.Report_box = new System.Windows.Forms.TextBox();
            this.Send_Click = new System.Windows.Forms.Button();
            this.Return_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Report_Notification
            // 
            this.Report_Notification.AutoSize = true;
            this.Report_Notification.Location = new System.Drawing.Point(268, 151);
            this.Report_Notification.Name = "Report_Notification";
            this.Report_Notification.Size = new System.Drawing.Size(523, 25);
            this.Report_Notification.TabIndex = 2;
            this.Report_Notification.Text = "\"Please describe what you\'d like to report in the box below.\"";
            this.Report_Notification.Click += new System.EventHandler(this.Report_Notification_Click);
            // 
            // Report_box
            // 
            this.Report_box.BackColor = System.Drawing.SystemColors.Info;
            this.Report_box.Location = new System.Drawing.Point(114, 235);
            this.Report_box.Multiline = true;
            this.Report_box.Name = "Report_box";
            this.Report_box.Size = new System.Drawing.Size(922, 216);
            this.Report_box.TabIndex = 3;
            this.Report_box.TextChanged += new System.EventHandler(this.Report_box_TextChanged);
            // 
            // Send_Click
            // 
            this.Send_Click.Location = new System.Drawing.Point(402, 498);
            this.Send_Click.Name = "Send_Click";
            this.Send_Click.Size = new System.Drawing.Size(97, 38);
            this.Send_Click.TabIndex = 8;
            this.Send_Click.Text = "Send";
            this.Send_Click.UseVisualStyleBackColor = true;
            this.Send_Click.Click += new System.EventHandler(this.Send_Click_Click);
            // 
            // Return_Click
            // 
            this.Return_Click.Location = new System.Drawing.Point(578, 498);
            this.Return_Click.Name = "Return_Click";
            this.Return_Click.Size = new System.Drawing.Size(94, 38);
            this.Return_Click.TabIndex = 9;
            this.Return_Click.Text = "Return";
            this.Return_Click.UseVisualStyleBackColor = true;
            this.Return_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1101, 644);
            this.Controls.Add(this.Return_Click);
            this.Controls.Add(this.Send_Click);
            this.Controls.Add(this.Report_box);
            this.Controls.Add(this.Report_Notification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Report_Notification;
        private System.Windows.Forms.TextBox Report_box;
        private System.Windows.Forms.Button Send_Click;
        private System.Windows.Forms.Button Return_Click;
    }
}