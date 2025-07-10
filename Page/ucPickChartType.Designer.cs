namespace Login.Page
{
    partial class ucPickChartType
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pickTypeLabel = new System.Windows.Forms.Label();
            this.PieChartButton = new System.Windows.Forms.Button();
            this.LineChartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pickTypeLabel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 65);
            this.panel3.TabIndex = 8;
            // 
            // pickTypeLabel
            // 
            this.pickTypeLabel.AutoSize = true;
            this.pickTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.pickTypeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.pickTypeLabel.Location = new System.Drawing.Point(47, 12);
            this.pickTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickTypeLabel.Name = "pickTypeLabel";
            this.pickTypeLabel.Size = new System.Drawing.Size(357, 37);
            this.pickTypeLabel.TabIndex = 2;
            this.pickTypeLabel.Text = "Please choose a chart type";
            // 
            // PieChartButton
            // 
            this.PieChartButton.BackColor = System.Drawing.Color.Salmon;
            this.PieChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PieChartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PieChartButton.ForeColor = System.Drawing.Color.White;
            this.PieChartButton.Location = new System.Drawing.Point(32, 84);
            this.PieChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.PieChartButton.Name = "PieChartButton";
            this.PieChartButton.Size = new System.Drawing.Size(178, 145);
            this.PieChartButton.TabIndex = 9;
            this.PieChartButton.Text = "Category Spending (%)";
            this.PieChartButton.UseVisualStyleBackColor = false;
            this.PieChartButton.Click += new System.EventHandler(this.PieChartButton_Click);
            // 
            // LineChartButton
            // 
            this.LineChartButton.BackColor = System.Drawing.Color.Salmon;
            this.LineChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LineChartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineChartButton.ForeColor = System.Drawing.Color.White;
            this.LineChartButton.Location = new System.Drawing.Point(237, 84);
            this.LineChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.LineChartButton.Name = "LineChartButton";
            this.LineChartButton.Size = new System.Drawing.Size(178, 145);
            this.LineChartButton.TabIndex = 10;
            this.LineChartButton.Text = "Monthly Savings";
            this.LineChartButton.UseVisualStyleBackColor = false;
            this.LineChartButton.Click += new System.EventHandler(this.LineChartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(32, 243);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(70, 30);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ucPickChartType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LineChartButton);
            this.Controls.Add(this.PieChartButton);
            this.Controls.Add(this.panel3);
            this.Name = "ucPickChartType";
            this.Size = new System.Drawing.Size(443, 284);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pickTypeLabel;
        private System.Windows.Forms.Button PieChartButton;
        private System.Windows.Forms.Button LineChartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
