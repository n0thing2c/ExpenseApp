using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class ucLoadFMFile: UserControl
    {
        public event EventHandler ExitButtonClicked;
        public ucLoadFMFile()
        {
            InitializeComponent();
            //this.MyExpenses.CellValidating += new DataGridViewCellValidatingEventHandler(this.CellValidating);
        }
        private FMFile file = new FMFile();
        public void LoadFile(string path)
        {
            FileName.Text = path.Remove(path.Length - 4).Substring(path.LastIndexOf('\\') + 1).Replace('_', ' ');
            file.SetPath(path);
            file.LoadTotable(MyExpenses);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Sumres_Calculate();
            OutRes_Calculate();
            InRes_Calculate();
            MaxMoneyUsedDay();
            MaxMoneyMakedDay();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            file.SaveFrom(MyExpenses);
            MessageBox.Show("Saved successfully");
        }

        private void Sumres_Calculate()
        {
            long sum = 0;
            foreach (DataGridViewRow row in MyExpenses.Rows)
            {
                if (row.Cells[2].Value != "")
                    sum -= Convert.ToInt64(row.Cells[2].Value);
                if (row.Cells[3].Value != "")
                    sum += Convert.ToInt64(row.Cells[3].Value);
            }
            Sumres.Text = sum.ToString();
        }
        private void OutRes_Calculate()
        {
            long sum = 0;
            foreach (DataGridViewRow row in MyExpenses.Rows)
            {
                if (row.Cells[2].Value != "")
                    sum += Convert.ToInt64(row.Cells[2].Value);

            }
            OutRes.Text = sum.ToString();
        }
        private void InRes_Calculate()
        {
            long sum = 0;
            foreach (DataGridViewRow row in MyExpenses.Rows)
            {
                if (row.Cells[3].Value != "")
                    sum += Convert.ToInt64(row.Cells[3].Value);

            }
            InRes.Text = sum.ToString();
        }
        private void MaxMoneyUsedDay()
        {
            long max = 0;
            int idx = 0;
            foreach (DataGridViewRow row in MyExpenses.Rows)
            {
                if (row.Cells[2].Value != "")
                {
                    long value = Convert.ToInt64(row.Cells[2].Value);
                    if (value > max)
                    {
                        max = value;
                        idx = row.Index;
                    }
                }
            }
            MostSpendDayRes.Text = Convert.ToString(MyExpenses.Rows[idx].Cells[0].Value) + ": " + Convert.ToString(max);
        }
        private void MaxMoneyMakedDay()
        {
            long max = 0;
            int idx = 0;
            foreach (DataGridViewRow row in MyExpenses.Rows)
            {
                if (row.Cells[3].Value != "")
                {
                    long value = Convert.ToInt64(row.Cells[3].Value);
                    if (value > max)
                    {
                        max = value;
                        idx = row.Index;
                    }
                }
            }
            MostMakeDayRes.Text = Convert.ToString(MyExpenses.Rows[idx].Cells[0].Value) + ": " + Convert.ToString(max);
        }
        private void MyExpenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            Sumres_Calculate();
            OutRes_Calculate();
            InRes_Calculate();
            MaxMoneyUsedDay();
            MaxMoneyMakedDay();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || MyExpenses.Rows[e.RowIndex].IsNewRow)
                return;

            string columnName = MyExpenses.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Date":
                    if (!int.TryParse(e.FormattedValue.ToString(), out int day) || day <= 0 || day > 31)
                    {
                        MessageBox.Show("Invalid day, please enter again", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Giữ người dùng ở lại ô cho đến khi sửa đúng
                    }
                    break;

                case "MoneyOut":
                    
                    if (!long.TryParse(e.FormattedValue.ToString().Replace(".", "").Replace(",", ""), out _))
                    {
                        MessageBox.Show("Invalid number, please enter again");
                        e.Cancel = true;
                    }
                    break;

                case "MoneyIn":
                    
                    if (!long.TryParse(e.FormattedValue.ToString().Replace(".", "").Replace(",", ""), out _))
                    {
                        MessageBox.Show("Invalid number, please enter again");
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void MyExpenses_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.Value is string str)
            {
                if (long.TryParse(str.Replace(".", ""), out long number))
                {
                    e.Value = number; // Store raw number
                    e.ParsingApplied = true;
                }
            }
        }

        private void MyExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.Value != null)
            {
                if (e.Value is long Value)
                {
                    e.Value = Value.ToString("N0", new CultureInfo("de-DE"));
                    e.FormattingApplied = true;
                }
            }
        }
        private void MyExpenses_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int cellidx;
            if (e.ColumnIndex == 2)
                cellidx = 3;
            else if (e.ColumnIndex == 3)
                cellidx = 2;
            else
                return;
            if (MyExpenses.Rows[e.RowIndex].Cells[cellidx].Value == null)
                return;
            if (long.TryParse(MyExpenses.Rows[e.RowIndex].Cells[cellidx].Value.ToString(), out long value))
            {
                MessageBox.Show("Cannot enter 'Spend' and 'Earn' on the same line");
                e.Cancel = true;
            }
        }
    }
}
