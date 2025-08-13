namespace Login.Page
{
    partial class ucLoadMDFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupExpenses = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NamePicker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Spend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddpersonButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemovePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupExpenses
            // 
            this.GroupExpenses.AllowUserToResizeColumns = false;
            this.GroupExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GroupExpenses.BackgroundColor = System.Drawing.Color.White;
            this.GroupExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GroupExpenses.ColumnHeadersHeight = 60;
            this.GroupExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GroupExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Content,
            this.NamePicker,
            this.Spend,
            this.Description});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupExpenses.DefaultCellStyle = dataGridViewCellStyle8;
            this.GroupExpenses.GridColor = System.Drawing.Color.Black;
            this.GroupExpenses.Location = new System.Drawing.Point(51, 132);
            this.GroupExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupExpenses.Name = "GroupExpenses";
            this.GroupExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GroupExpenses.RowHeadersWidth = 45;
            this.GroupExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupExpenses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GroupExpenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupExpenses.RowTemplate.Height = 60;
            this.GroupExpenses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupExpenses.Size = new System.Drawing.Size(1269, 442);
            this.GroupExpenses.StandardTab = true;
            this.GroupExpenses.TabIndex = 5;
            this.GroupExpenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GroupExpenses_CellFormatting);
            this.GroupExpenses.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.GroupExpenses_CellParsing);
            this.GroupExpenses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CellValidating);
            this.GroupExpenses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupExpenses_CellValueChanged);
            this.GroupExpenses.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.GroupExpenses_SortCompare);
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "d";
            this.Day.DefaultCellStyle = dataGridViewCellStyle3;
            this.Day.FillWeight = 32F;
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Content
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.DefaultCellStyle = dataGridViewCellStyle4;
            this.Content.FillWeight = 32F;
            this.Content.HeaderText = "Content";
            this.Content.Items.AddRange(new object[] {
            "Rent",
            "Food & Beverages",
            "Utilities bill",
            "Transportation",
            "Shopping",
            "Insurance",
            "Loan",
            "Job",
            "Medicals",
            "Entertainment",
            "Others"});
            this.Content.MinimumWidth = 8;
            this.Content.Name = "Content";
            this.Content.Width = 160;
            // 
            // NamePicker
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePicker.DefaultCellStyle = dataGridViewCellStyle5;
            this.NamePicker.FillWeight = 21F;
            this.NamePicker.HeaderText = "Name";
            this.NamePicker.Items.AddRange(new object[] {
            ""});
            this.NamePicker.MinimumWidth = 6;
            this.NamePicker.Name = "NamePicker";
            this.NamePicker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NamePicker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NamePicker.Width = 160;
            // 
            // Spend
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spend.DefaultCellStyle = dataGridViewCellStyle6;
            this.Spend.FillWeight = 21F;
            this.Spend.HeaderText = "Spend";
            this.Spend.MinimumWidth = 6;
            this.Spend.Name = "Spend";
            this.Spend.Width = 160;
            // 
            // Description
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Description.DefaultCellStyle = dataGridViewCellStyle7;
            this.Description.FillWeight = 130F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 250;
            // 
            // AddpersonButton
            // 
            this.AddpersonButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddpersonButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddpersonButton.ForeColor = System.Drawing.Color.White;
            this.AddpersonButton.Location = new System.Drawing.Point(51, 57);
            this.AddpersonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddpersonButton.Name = "AddpersonButton";
            this.AddpersonButton.Size = new System.Drawing.Size(160, 70);
            this.AddpersonButton.TabIndex = 1;
            this.AddpersonButton.Text = "Add person";
            this.AddpersonButton.UseVisualStyleBackColor = false;
            this.AddpersonButton.Click += new System.EventHandler(this.AddpersonButton_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(448, 66);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(174, 38);
            this.FileName.TabIndex = 2;
            this.FileName.Text = "File Name";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Violet;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.PapayaWhip;
            this.SaveButton.Location = new System.Drawing.Point(1219, 623);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 57);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Result
            // 
            this.Result.BackgroundColor = System.Drawing.Color.White;
            this.Result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Result.ColumnHeadersHeight = 40;
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Result.GridColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(247, 578);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Name = "Result";
            this.Result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result.RowHeadersWidth = 51;
            this.Result.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Result.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.RowTemplate.Height = 45;
            this.Result.Size = new System.Drawing.Size(757, 128);
            this.Result.TabIndex = 9;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.PapayaWhip;
            this.ExitButton.Location = new System.Drawing.Point(25, 623);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(121, 57);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources.legend;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1013, 590);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            // 
            // RemovePersonButton
            // 
            this.RemovePersonButton.BackColor = System.Drawing.Color.Maroon;
            this.RemovePersonButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePersonButton.ForeColor = System.Drawing.Color.White;
            this.RemovePersonButton.Location = new System.Drawing.Point(216, 57);
            this.RemovePersonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemovePersonButton.Name = "RemovePersonButton";
            this.RemovePersonButton.Size = new System.Drawing.Size(160, 70);
            this.RemovePersonButton.TabIndex = 15;
            this.RemovePersonButton.Text = "Remove person";
            this.RemovePersonButton.UseVisualStyleBackColor = false;
            this.RemovePersonButton.Click += new System.EventHandler(this.RemovePerson_Click);
            // 
            // ucLoadMDFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RemovePersonButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.AddpersonButton);
            this.Controls.Add(this.GroupExpenses);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucLoadMDFile";
            this.Size = new System.Drawing.Size(1375, 708);
            ((System.ComponentModel.ISupportInitialize)(this.GroupExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupExpenses;
        private System.Windows.Forms.Button AddpersonButton;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemovePersonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewComboBoxColumn Content;
        private System.Windows.Forms.DataGridViewComboBoxColumn NamePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
