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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.resultpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // resultpanel
            // 
            this.resultpanel.BackColor = System.Drawing.Color.FloralWhite;
            this.resultpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.resultpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultpanel.ForeColor = System.Drawing.Color.White;
            this.resultpanel.Location = new System.Drawing.Point(2, 122);
            this.resultpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(199, 250);
            this.resultpanel.TabIndex = 3;
            // 
            // MostMakeDayRes
            // 
            this.MostMakeDayRes.AutoSize = true;
            this.MostMakeDayRes.ForeColor = System.Drawing.Color.SeaGreen;
            this.MostMakeDayRes.Location = new System.Drawing.Point(22, 210);
            this.MostMakeDayRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MostMakeDayRes.Name = "MostMakeDayRes";
            this.MostMakeDayRes.Size = new System.Drawing.Size(48, 17);
            this.MostMakeDayRes.TabIndex = 11;
            this.MostMakeDayRes.Text = "NULL";
            // 
            // MostIncomeDay
            // 
            this.MostIncomeDay.AutoSize = true;
            this.MostIncomeDay.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostIncomeDay.ForeColor = System.Drawing.Color.Salmon;
            this.MostIncomeDay.Location = new System.Drawing.Point(18, 175);
            this.MostIncomeDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MostIncomeDay.Name = "MostIncomeDay";
            this.MostIncomeDay.Size = new System.Drawing.Size(135, 21);
            this.MostIncomeDay.TabIndex = 10;
            this.MostIncomeDay.Text = "Most earned day:";
            // 
            // MostSpendDayRes
            // 
            this.MostSpendDayRes.AutoSize = true;
            this.MostSpendDayRes.ForeColor = System.Drawing.Color.Crimson;
            this.MostSpendDayRes.Location = new System.Drawing.Point(22, 154);
            this.MostSpendDayRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MostSpendDayRes.Name = "MostSpendDayRes";
            this.MostSpendDayRes.Size = new System.Drawing.Size(48, 17);
            this.MostSpendDayRes.TabIndex = 9;
            this.MostSpendDayRes.Text = "NULL";
            // 
            // MostSpendDayLabel
            // 
            this.MostSpendDayLabel.AutoSize = true;
            this.MostSpendDayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostSpendDayLabel.ForeColor = System.Drawing.Color.Salmon;
            this.MostSpendDayLabel.Location = new System.Drawing.Point(18, 122);
            this.MostSpendDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MostSpendDayLabel.Name = "MostSpendDayLabel";
            this.MostSpendDayLabel.Size = new System.Drawing.Size(129, 21);
            this.MostSpendDayLabel.TabIndex = 8;
            this.MostSpendDayLabel.Text = "Most spent day: ";
            // 
            // InRes
            // 
            this.InRes.AutoSize = true;
            this.InRes.ForeColor = System.Drawing.Color.Red;
            this.InRes.Location = new System.Drawing.Point(135, 98);
            this.InRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InRes.Name = "InRes";
            this.InRes.Size = new System.Drawing.Size(48, 17);
            this.InRes.TabIndex = 7;
            this.InRes.Text = "NULL";
            // 
            // SumIn
            // 
            this.SumIn.AutoSize = true;
            this.SumIn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumIn.ForeColor = System.Drawing.Color.Salmon;
            this.SumIn.Location = new System.Drawing.Point(18, 90);
            this.SumIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SumIn.Name = "SumIn";
            this.SumIn.Size = new System.Drawing.Size(99, 21);
            this.SumIn.TabIndex = 6;
            this.SumIn.Text = "Total spend:";
            // 
            // OutRes
            // 
            this.OutRes.AutoSize = true;
            this.OutRes.ForeColor = System.Drawing.Color.LightGreen;
            this.OutRes.Location = new System.Drawing.Point(135, 66);
            this.OutRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutRes.Name = "OutRes";
            this.OutRes.Size = new System.Drawing.Size(48, 17);
            this.OutRes.TabIndex = 4;
            this.OutRes.Text = "NULL";
            // 
            // SumOut
            // 
            this.SumOut.AutoSize = true;
            this.SumOut.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOut.ForeColor = System.Drawing.Color.Salmon;
            this.SumOut.Location = new System.Drawing.Point(18, 58);
            this.SumOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SumOut.Name = "SumOut";
            this.SumOut.Size = new System.Drawing.Size(110, 21);
            this.SumOut.TabIndex = 5;
            this.SumOut.Text = "Total income:";
            // 
            // Sumres
            // 
            this.Sumres.AutoSize = true;
            this.Sumres.ForeColor = System.Drawing.Color.Black;
            this.Sumres.Location = new System.Drawing.Point(135, 34);
            this.Sumres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sumres.Name = "Sumres";
            this.Sumres.Size = new System.Drawing.Size(48, 17);
            this.Sumres.TabIndex = 3;
            this.Sumres.Text = "NULL";
            // 
            // Sumlabel
            // 
            this.Sumlabel.AutoSize = true;
            this.Sumlabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumlabel.ForeColor = System.Drawing.Color.Salmon;
            this.Sumlabel.Location = new System.Drawing.Point(18, 26);
            this.Sumlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sumlabel.Name = "Sumlabel";
            this.Sumlabel.Size = new System.Drawing.Size(103, 21);
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
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.MyExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.MyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Content,
            this.MoneyOut,
            this.MoneyIn,
            this.Details,
            this.Means});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyExpenses.DefaultCellStyle = dataGridViewCellStyle35;
            this.MyExpenses.GridColor = System.Drawing.Color.Black;
            this.MyExpenses.Location = new System.Drawing.Point(206, 122);
            this.MyExpenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyExpenses.Name = "MyExpenses";
            this.MyExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.MyExpenses.RowHeadersWidth = 45;
            this.MyExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MyExpenses.Size = new System.Drawing.Size(1137, 661);
            this.MyExpenses.TabIndex = 4;
            this.MyExpenses.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MyExpenses_CellBeginEdit);
            this.MyExpenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MyExpenses_CellFormatting);
            this.MyExpenses.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.MyExpenses_CellParsing);
            this.MyExpenses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CellValidating);
            this.MyExpenses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyExpenses_CellValueChanged);
            // 
            // Date
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightCyan;
            this.Date.DefaultCellStyle = dataGridViewCellStyle29;
            this.Date.FillWeight = 64.17112F;
            this.Date.HeaderText = "Day";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Content
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Content.DefaultCellStyle = dataGridViewCellStyle30;
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Crimson;
            this.MoneyOut.DefaultCellStyle = dataGridViewCellStyle31;
            this.MoneyOut.FillWeight = 102.711F;
            this.MoneyOut.HeaderText = "Spend";
            this.MoneyOut.MinimumWidth = 6;
            this.MoneyOut.Name = "MoneyOut";
            this.MoneyOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MoneyIn
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.SeaGreen;
            this.MoneyIn.DefaultCellStyle = dataGridViewCellStyle32;
            this.MoneyIn.FillWeight = 95.73236F;
            this.MoneyIn.HeaderText = "Earn";
            this.MoneyIn.MinimumWidth = 6;
            this.MoneyIn.Name = "MoneyIn";
            this.MoneyIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Details
            // 
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.DefaultCellStyle = dataGridViewCellStyle33;
            this.Details.FillWeight = 177.2692F;
            this.Details.HeaderText = "Description";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Means
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Means.DefaultCellStyle = dataGridViewCellStyle34;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 7;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(730, 36);
            this.FileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(127, 29);
            this.FileName.TabIndex = 8;
            this.FileName.Text = "FileName";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.BackgroundImage = global::Login.Properties.Resources._return;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(18, 14);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 62);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = global::Login.Properties.Resources.saveFile1;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(196, 14);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveButton.Size = new System.Drawing.Size(91, 57);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 784);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MyExpenses);
            this.Controls.Add(this.resultpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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