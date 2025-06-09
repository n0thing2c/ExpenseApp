namespace Login.Page
{
    partial class LoadFileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resultpanel = new System.Windows.Forms.Panel();
            this.MostMakeDayRes = new System.Windows.Forms.Label();
            this.MostIncomeDay = new System.Windows.Forms.Label();
            this.MostSpendDayRes = new System.Windows.Forms.Label();
            this.MostSpendDayLabel = new System.Windows.Forms.Label();
            this.InRes = new System.Windows.Forms.Label();
            this.SumIn = new System.Windows.Forms.Label();
            this.OutRes = new System.Windows.Forms.Label();
            this.SumOut = new System.Windows.Forms.Label();
            this.Sumres = new System.Windows.Forms.Label();
            this.Sumlabel = new System.Windows.Forms.Label();
            this.MyExpenses = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MoneyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Means = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.resultpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // resultpanel
            // 
            this.resultpanel.BackColor = System.Drawing.Color.Salmon;
            this.resultpanel.Controls.Add(this.MostMakeDayRes);
            this.resultpanel.Controls.Add(this.MostIncomeDay);
            this.resultpanel.Controls.Add(this.MostSpendDayRes);
            this.resultpanel.Controls.Add(this.MostSpendDayLabel);
            this.resultpanel.Controls.Add(this.InRes);
            this.resultpanel.Controls.Add(this.SumIn);
            this.resultpanel.Controls.Add(this.OutRes);
            this.resultpanel.Controls.Add(this.SumOut);
            this.resultpanel.Controls.Add(this.Sumres);
            this.resultpanel.Controls.Add(this.Sumlabel);
            this.resultpanel.ForeColor = System.Drawing.Color.White;
            this.resultpanel.Location = new System.Drawing.Point(31, 179);
            this.resultpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(221, 308);
            this.resultpanel.TabIndex = 3;
            // 
            // MostMakeDayRes
            // 
            this.MostMakeDayRes.AutoSize = true;
            this.MostMakeDayRes.ForeColor = System.Drawing.Color.MistyRose;
            this.MostMakeDayRes.Location = new System.Drawing.Point(27, 262);
            this.MostMakeDayRes.Name = "MostMakeDayRes";
            this.MostMakeDayRes.Size = new System.Drawing.Size(41, 16);
            this.MostMakeDayRes.TabIndex = 11;
            this.MostMakeDayRes.Text = "NULL";
            // 
            // MostIncomeDay
            // 
            this.MostIncomeDay.AutoSize = true;
            this.MostIncomeDay.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostIncomeDay.ForeColor = System.Drawing.Color.White;
            this.MostIncomeDay.Location = new System.Drawing.Point(23, 219);
            this.MostIncomeDay.Name = "MostIncomeDay";
            this.MostIncomeDay.Size = new System.Drawing.Size(174, 28);
            this.MostIncomeDay.TabIndex = 10;
            this.MostIncomeDay.Text = "Most earned day:";
            // 
            // MostSpendDayRes
            // 
            this.MostSpendDayRes.AutoSize = true;
            this.MostSpendDayRes.ForeColor = System.Drawing.Color.MistyRose;
            this.MostSpendDayRes.Location = new System.Drawing.Point(27, 192);
            this.MostSpendDayRes.Name = "MostSpendDayRes";
            this.MostSpendDayRes.Size = new System.Drawing.Size(41, 16);
            this.MostSpendDayRes.TabIndex = 9;
            this.MostSpendDayRes.Text = "NULL";
            // 
            // MostSpendDayLabel
            // 
            this.MostSpendDayLabel.AutoSize = true;
            this.MostSpendDayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostSpendDayLabel.ForeColor = System.Drawing.Color.White;
            this.MostSpendDayLabel.Location = new System.Drawing.Point(23, 153);
            this.MostSpendDayLabel.Name = "MostSpendDayLabel";
            this.MostSpendDayLabel.Size = new System.Drawing.Size(167, 28);
            this.MostSpendDayLabel.TabIndex = 8;
            this.MostSpendDayLabel.Text = "Most spent day: ";
            // 
            // InRes
            // 
            this.InRes.AutoSize = true;
            this.InRes.ForeColor = System.Drawing.Color.MistyRose;
            this.InRes.Location = new System.Drawing.Point(169, 123);
            this.InRes.Name = "InRes";
            this.InRes.Size = new System.Drawing.Size(41, 16);
            this.InRes.TabIndex = 7;
            this.InRes.Text = "NULL";
            // 
            // SumIn
            // 
            this.SumIn.AutoSize = true;
            this.SumIn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumIn.ForeColor = System.Drawing.Color.White;
            this.SumIn.Location = new System.Drawing.Point(23, 113);
            this.SumIn.Name = "SumIn";
            this.SumIn.Size = new System.Drawing.Size(128, 28);
            this.SumIn.TabIndex = 6;
            this.SumIn.Text = "Total spend:";
            // 
            // OutRes
            // 
            this.OutRes.AutoSize = true;
            this.OutRes.ForeColor = System.Drawing.Color.MistyRose;
            this.OutRes.Location = new System.Drawing.Point(169, 83);
            this.OutRes.Name = "OutRes";
            this.OutRes.Size = new System.Drawing.Size(41, 16);
            this.OutRes.TabIndex = 4;
            this.OutRes.Text = "NULL";
            // 
            // SumOut
            // 
            this.SumOut.AutoSize = true;
            this.SumOut.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOut.ForeColor = System.Drawing.Color.White;
            this.SumOut.Location = new System.Drawing.Point(23, 73);
            this.SumOut.Name = "SumOut";
            this.SumOut.Size = new System.Drawing.Size(140, 28);
            this.SumOut.TabIndex = 5;
            this.SumOut.Text = "Total income:";
            // 
            // Sumres
            // 
            this.Sumres.AutoSize = true;
            this.Sumres.ForeColor = System.Drawing.Color.MistyRose;
            this.Sumres.Location = new System.Drawing.Point(169, 42);
            this.Sumres.Name = "Sumres";
            this.Sumres.Size = new System.Drawing.Size(41, 16);
            this.Sumres.TabIndex = 3;
            this.Sumres.Text = "NULL";
            // 
            // Sumlabel
            // 
            this.Sumlabel.AutoSize = true;
            this.Sumlabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumlabel.ForeColor = System.Drawing.Color.White;
            this.Sumlabel.Location = new System.Drawing.Point(23, 32);
            this.Sumlabel.Name = "Sumlabel";
            this.Sumlabel.Size = new System.Drawing.Size(131, 28);
            this.Sumlabel.TabIndex = 3;
            this.Sumlabel.Text = "Net Balance:";
            // 
            // MyExpenses
            // 
            this.MyExpenses.AllowUserToResizeColumns = false;
            this.MyExpenses.AllowUserToResizeRows = false;
            this.MyExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyExpenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MyExpenses.BackgroundColor = System.Drawing.Color.White;
            this.MyExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.MyExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Content,
            this.MoneyOut,
            this.MoneyIn,
            this.Details,
            this.Means});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyExpenses.DefaultCellStyle = dataGridViewCellStyle8;
            this.MyExpenses.GridColor = System.Drawing.Color.Black;
            this.MyExpenses.Location = new System.Drawing.Point(258, 152);
            this.MyExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyExpenses.Name = "MyExpenses";
            this.MyExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MyExpenses.RowHeadersWidth = 45;
            this.MyExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MyExpenses.Size = new System.Drawing.Size(1421, 826);
            this.MyExpenses.TabIndex = 4;
            this.MyExpenses.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MyExpenses_CellBeginEdit);
            this.MyExpenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MyExpenses_CellFormatting);
            this.MyExpenses.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.MyExpenses_CellParsing);
            this.MyExpenses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CellValidating);
            this.MyExpenses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyExpenses_CellValueChanged);
            // 
            // Date
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.FillWeight = 64.17112F;
            this.Date.HeaderText = "Day";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Content
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Content.DefaultCellStyle = dataGridViewCellStyle3;
            this.Content.FillWeight = 78.60345F;
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
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MoneyOut
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson;
            this.MoneyOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.MoneyOut.FillWeight = 102.711F;
            this.MoneyOut.HeaderText = "Spend";
            this.MoneyOut.MinimumWidth = 6;
            this.MoneyOut.Name = "MoneyOut";
            this.MoneyOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MoneyIn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            this.MoneyIn.DefaultCellStyle = dataGridViewCellStyle5;
            this.MoneyIn.FillWeight = 95.73236F;
            this.MoneyIn.HeaderText = "Earn";
            this.MoneyIn.MinimumWidth = 6;
            this.MoneyIn.Name = "MoneyIn";
            this.MoneyIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Details
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.DefaultCellStyle = dataGridViewCellStyle6;
            this.Details.FillWeight = 177.2692F;
            this.Details.HeaderText = "Description";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Means
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Means.DefaultCellStyle = dataGridViewCellStyle7;
            this.Means.FillWeight = 81.5128F;
            this.Means.HeaderText = "Transaction method";
            this.Means.Items.AddRange(new object[] {
            "Momo",
            "VCB",
            "Cash",
            "Debit/Credit Card",
            "E-Wallet",
            "Agribank",
            "BIDV",
            "MB Bank",
            "TCB",
            "VIB",
            "OCB",
            "ACB"});
            this.Means.MinimumWidth = 6;
            this.Means.Name = "Means";
            this.Means.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1424, 28);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 57);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Return";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1565, 28);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 57);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 7;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(25, 32);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(148, 36);
            this.FileName.TabIndex = 8;
            this.FileName.Text = "FileName";
            // 
            // LoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MyExpenses);
            this.Controls.Add(this.resultpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadFileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LoadFile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.resultpanel.ResumeLayout(false);
            this.resultpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel resultpanel;
        private System.Windows.Forms.Label MostMakeDayRes;
        private System.Windows.Forms.Label MostIncomeDay;
        private System.Windows.Forms.Label MostSpendDayRes;
        private System.Windows.Forms.Label MostSpendDayLabel;
        private System.Windows.Forms.Label InRes;
        private System.Windows.Forms.Label SumIn;
        private System.Windows.Forms.Label OutRes;
        private System.Windows.Forms.Label SumOut;
        private System.Windows.Forms.Label Sumres;
        private System.Windows.Forms.Label Sumlabel;
        private System.Windows.Forms.DataGridView MyExpenses;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewComboBoxColumn Means;
    }
}