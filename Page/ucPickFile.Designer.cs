namespace Login.Page
{
    partial class ucPickFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilesAreBelowLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.listBoxFiles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 279);
            this.panel1.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(176, 240);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(70, 27);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Return";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.OpenButton.Location = new System.Drawing.Point(325, 240);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(70, 27);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteButton.Location = new System.Drawing.Point(250, 240);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(70, 27);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AccessibleName = "";
            this.listBoxFiles.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 25;
            this.listBoxFiles.Location = new System.Drawing.Point(19, 72);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(396, 154);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.OpenButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FilesAreBelowLabel);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 46);
            this.panel2.TabIndex = 6;
            // 
            // FilesAreBelowLabel
            // 
            this.FilesAreBelowLabel.AutoSize = true;
            this.FilesAreBelowLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilesAreBelowLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesAreBelowLabel.ForeColor = System.Drawing.Color.Black;
            this.FilesAreBelowLabel.Location = new System.Drawing.Point(124, 3);
            this.FilesAreBelowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilesAreBelowLabel.Name = "FilesAreBelowLabel";
            this.FilesAreBelowLabel.Size = new System.Drawing.Size(200, 37);
            this.FilesAreBelowLabel.TabIndex = 2;
            this.FilesAreBelowLabel.Text = "Available Files";
            // 
            // ucPickFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucPickFile";
            this.Size = new System.Drawing.Size(436, 282);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label FilesAreBelowLabel;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Panel panel2;
    }
}
