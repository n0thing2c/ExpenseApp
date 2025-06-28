namespace Login.Page
{
    partial class ucNewFile
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
            this.MakeFileButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.YearPicker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MonthPicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearPicker)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.MakeFileButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 246);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Salmon;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(133, 206);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 30);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Return";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MakeFileButton
            // 
            this.MakeFileButton.BackColor = System.Drawing.Color.Salmon;
            this.MakeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeFileButton.ForeColor = System.Drawing.Color.White;
            this.MakeFileButton.Location = new System.Drawing.Point(242, 206);
            this.MakeFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MakeFileButton.Name = "MakeFileButton";
            this.MakeFileButton.Size = new System.Drawing.Size(91, 30);
            this.MakeFileButton.TabIndex = 3;
            this.MakeFileButton.Text = "Make File";
            this.MakeFileButton.UseVisualStyleBackColor = false;
            this.MakeFileButton.Click += new System.EventHandler(this.MakeFileButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.YearPicker);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(21, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 66);
            this.panel3.TabIndex = 2;
            // 
            // YearPicker
            // 
            this.YearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearPicker.Location = new System.Drawing.Point(176, 18);
            this.YearPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearPicker.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.YearPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(149, 28);
            this.YearPicker.TabIndex = 2;
            this.YearPicker.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year of expense:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MonthPicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 59);
            this.panel2.TabIndex = 0;
            // 
            // MonthPicker
            // 
            this.MonthPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthPicker.Location = new System.Drawing.Point(176, 17);
            this.MonthPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthPicker.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(149, 28);
            this.MonthPicker.TabIndex = 3;
            this.MonthPicker.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month of expense:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 30);
            this.panel4.TabIndex = 2;
            // 
            // ucNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNewFile";
            this.Size = new System.Drawing.Size(381, 244);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearPicker)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MakeFileButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown YearPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown MonthPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}
