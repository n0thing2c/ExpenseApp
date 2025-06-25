namespace Login.Page
{
    partial class ucPickFileType
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MDFilePick = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PickTypeLabel = new System.Windows.Forms.Label();
            this.FMFilePick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FMFilePick);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.MDFilePick);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 349);
            this.panel2.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(33, 295);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 37);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MDFilePick
            // 
            this.MDFilePick.BackColor = System.Drawing.Color.Salmon;
            this.MDFilePick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDFilePick.ForeColor = System.Drawing.Color.White;
            this.MDFilePick.Location = new System.Drawing.Point(298, 102);
            this.MDFilePick.Name = "MDFilePick";
            this.MDFilePick.Size = new System.Drawing.Size(237, 178);
            this.MDFilePick.TabIndex = 1;
            this.MDFilePick.Text = "Group Money Divider File";
            this.MDFilePick.UseVisualStyleBackColor = false;
            this.MDFilePick.Click += new System.EventHandler(this.MDFilePick_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PickTypeLabel);
            this.panel3.Location = new System.Drawing.Point(-33, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 77);
            this.panel3.TabIndex = 7;
            // 
            // PickTypeLabel
            // 
            this.PickTypeLabel.AutoSize = true;
            this.PickTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PickTypeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.PickTypeLabel.Location = new System.Drawing.Point(110, 14);
            this.PickTypeLabel.Name = "PickTypeLabel";
            this.PickTypeLabel.Size = new System.Drawing.Size(399, 45);
            this.PickTypeLabel.TabIndex = 2;
            this.PickTypeLabel.Text = "Please choose a file type";
            // 
            // FMFilePick
            // 
            this.FMFilePick.BackColor = System.Drawing.Color.Salmon;
            this.FMFilePick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMFilePick.ForeColor = System.Drawing.Color.White;
            this.FMFilePick.Location = new System.Drawing.Point(33, 102);
            this.FMFilePick.Name = "FMFilePick";
            this.FMFilePick.Size = new System.Drawing.Size(237, 178);
            this.FMFilePick.TabIndex = 0;
            this.FMFilePick.Text = "Financial Management File";
            this.FMFilePick.UseVisualStyleBackColor = false;
            this.FMFilePick.Click += new System.EventHandler(this.FMFilePick_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 348);
            this.panel1.TabIndex = 3;
            // 
            // ucPickFileType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucPickFileType";
            this.Size = new System.Drawing.Size(591, 349);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FMFilePick;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PickTypeLabel;
        private System.Windows.Forms.Button MDFilePick;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
    }
}
