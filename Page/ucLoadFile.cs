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
    public partial class ucLoadFile: UserControl
    {
        public event EventHandler ExitButtonClicked;
        public ucLoadFile()
        {
            InitializeComponent();
            this.MyExpenses.CellValidating += new DataGridViewCellValidatingEventHandler(MyExpenses_CellValidating);
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

        private void MyExpenses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (MyExpenses.Columns[e.ColumnIndex].Name == "Date")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || MyExpenses.Rows[e.RowIndex].IsNewRow)
                {
                    return;
                }
                DateTime parsedDate;
                if (!DateTime.TryParseExact(e.FormattedValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    MessageBox.Show("Please enter in 'dd/MM/yyyy' format", "Invalid date format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
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
            if (e.FormattedValue.ToString() == "")
                return;
            switch (e.ColumnIndex)
            {
                case 0:

                    if (int.TryParse(e.FormattedValue.ToString(), out int month) == false || month <= 0 || month > 31)
                    {
                        MessageBox.Show("Incorrect value, please type in again");
                        e.Cancel = true;
                    }
                    break;
                case 2:
                    if (long.TryParse(MyExpenses.Rows[e.RowIndex].Cells[3].Value.ToString(), out long value))
                    {
                        MessageBox.Show("Spend and Earn can not be on the same row");
                        e.Cancel = true;
                    }
                    if (long.TryParse(e.FormattedValue.ToString().Replace(".", ""), out value) == false)
                    {
                        MessageBox.Show("Incorrect value, please type in again");
                        e.Cancel = true;
                    }
                    break;
                case 3:
                    if (long.TryParse(MyExpenses.Rows[e.RowIndex].Cells[2].Value.ToString(), out value))
                    {
                        MessageBox.Show("Spend and Earn can not be on the same row");
                        e.Cancel = true;
                    }
                    if (long.TryParse(e.FormattedValue.ToString().Replace(".", ""), out value) == false)
                    {
                        MessageBox.Show("Incorrect value, please type in again");
                        e.Cancel = true;
                    }

                    break;
                default:
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
    }
}
