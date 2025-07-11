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
    public partial class ucLoadMDFile : UserControl
    {
        int numofpeople = 0;
        List<string> peoplenames;
        public event EventHandler ExitButtonClicked;
        private bool isSaved = true;
        public ucLoadMDFile()
        {
            InitializeComponent();
            GroupExpenses.Rows[0].Height = 60;
        }
        private MDFile file = new MDFile();
        public void LoadFile(string path)
        {
            FileName.Text = path.Remove(path.Length - 4).Substring(path.LastIndexOf('\\') + 1).Replace('_', ' ');
            file.SetPath(path);
            //initialize from file
            numofpeople = file.GetNumberOfPeople();
            peoplenames = file.PeopleList().ToList();
            foreach (string peoplename in peoplenames)
            {
                NamePicker.Items.Add(peoplename);
            }
            LoadResultTable();
            file.LoadToTable(GroupExpenses);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
        }
        private void AddPerson(string name)
        {
            //add new person to class data
            numofpeople++;
            peoplenames.Add(name);
            //add new person to group expenses
            DataGridViewCheckBoxColumn personborrowcol = new DataGridViewCheckBoxColumn();
            personborrowcol.HeaderText = name;
            GroupExpenses.Columns.Insert(numofpeople + 3, personborrowcol);
            NamePicker.Items.Add(name);
            //add new person to result table
            DataGridViewTextBoxColumn personres = new DataGridViewTextBoxColumn();
            personres.HeaderText = name;
            Result.Columns.Add(personres);
            //re-calculate result
            Calculate();
        }
        private void AddpersonButton_Click(object sender, EventArgs e)
        {
            ucPersonInfo psi = new ucPersonInfo();
            psi.AddColumn += AddPerson;
            psi.names = peoplenames;
            this.Controls.Add(psi);
            psi.Location = new Point((psi.Parent.Width - psi.Width) / 2,
                                    (psi.Parent.Height - psi.Height) / 2);
            psi.BringToFront();
        }
        private void RemovePerson(string name)
        {
            //Remove person from every row of Name Column
            foreach(DataGridViewRow row in GroupExpenses.Rows)
            {
                if(!row.IsNewRow)
                {
                    if (row.Cells[2].Value?.ToString() == name)
                    {
                        row.Cells[2].Value = "";
                    }
                }
            }
            //Remove person from name list box
            peoplenames.Remove(name);
            //Remove person from Column Check Box
            foreach (DataGridViewColumn column in GroupExpenses.Columns)
            {
                if (column.HeaderText == name)
                {
                    GroupExpenses.Columns.Remove(column);
                    break;
                }
            }
            //Remove person from Result table
            foreach(DataGridViewColumn columnres in Result.Columns)
            {
                if (columnres.HeaderText == name)
                {
                    Result.Columns.Remove(columnres);
                    break;
                }
            }
            //Remove person from class data
            NamePicker.Items.Remove(name);
            numofpeople--;
            //Re-Calculate result table
            Calculate();
        }
        private void RemovePerson_Click(object sender, EventArgs e)
        {
            ucRemovePersonPicker rpp = new ucRemovePersonPicker();
            rpp.DeleteColumn += RemovePerson;
            rpp.names = peoplenames.ToList();
            rpp.ShowListBox();
            this.Controls.Add(rpp);
            rpp.Location = new Point((rpp.Parent.Width - rpp.Width) / 2,
                                    (rpp.Parent.Height - rpp.Height) / 2);
            rpp.BringToFront();
        }
        private void GroupExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 3) && e.Value != null)
            {
                if (e.Value is long Value)
                {
                    e.Value = Value.ToString("C0", new CultureInfo("vi-VN"));
                    e.FormattingApplied = true;
                }
            }
        }
        private void GroupExpenses_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if ((e.ColumnIndex == 3) && e.Value is string str)
            {
                if (long.TryParse(str.Replace(".", "").Replace("₫", ""), out long number))
                {
                    e.Value = number; // Store raw number
                    e.ParsingApplied = true;
                }
            }
        }
        private void CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || GroupExpenses.Rows[e.RowIndex].IsNewRow)
                return;
            string columnName = GroupExpenses.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Day":
                    if (!int.TryParse(e.FormattedValue.ToString(), out int day) || day <= 0 || day > 31)
                    {
                        MessageBox.Show("Invalid day, please enter again", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Giữ người dùng ở lại ô cho đến khi sửa đúng
                    }
                    break;

                case "Spend":
                    if (!ulong.TryParse(e.FormattedValue.ToString().Replace(".", "").Replace(",", "").Replace("₫",""), out _))
                    {
                        MessageBox.Show("Invalid number, please enter again");
                        e.Cancel = true;
                    }
                    break;
            }
        }
        
        private void Calculate()
        {
            //make name list and balance list for each person in the table
            double[] res = new double[numofpeople];
            foreach (DataGridViewRow row in GroupExpenses.Rows)
            {
                if (!row.IsNewRow)
                {
                    //determine the spender of the row
                    string spender = row.Cells[2].Value?.ToString();
                    int spenderidx = peoplenames.IndexOf(spender);
                    if (spenderidx == -1) continue;
                    long.TryParse(row.Cells[3].Value?.ToString(), out long spend);
                    //increase the spender balance
                    res[spenderidx] += spend;
                    //determine the number of people who borrows the spender
                    long numofborrower = 0;
                    for (int i = 0; i < numofpeople; i++)
                    {
                        if (Convert.ToBoolean(row.Cells[i + 4].Value) == true)
                        {
                            numofborrower++;
                        }
                    }
                    //if no one borrows, decrease the spender balance
                    if (numofborrower == 0)
                    {
                        res[spenderidx] -= spend;
                    }
                    //decrease balance of borrowers
                    for (int i = 0; i < numofpeople; i++)
                    {
                        if (Convert.ToBoolean(row.Cells[i + 4].Value) == true)
                        {
                            res[i] -= spend * 1.0 / numofborrower;
                        }
                    }
                }
            }
            //write to result table
            for (int i = 0; i < numofpeople; i++)
            {
                Result.Rows[0].Cells[i].Value = res[i];
                if (res[i] > 0)
                    Result.Columns[i].DefaultCellStyle.BackColor = Color.Green;
                else if(res[i] < 0)
                    Result.Columns[i].DefaultCellStyle.BackColor = Color.Maroon;
                else
                    Result.Columns[i].DefaultCellStyle.BackColor = Color.Gray;
            }

        }
        private void LoadResultTable()
        {
            //Add name columns 
            foreach (string peoplename in peoplenames)
            {
                Result.Columns.Add(peoplename, peoplename);
            }
            //Set format for double
            var culture = new System.Globalization.CultureInfo("vi-VN");

            // Apply format for double

            Result.DefaultCellStyle.Format = "c2";
            Result.DefaultCellStyle.FormatProvider = culture;
            //Calculate result
            Calculate();
        }

        private void GroupExpenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calculate();
            isSaved = false;
        }
        private void GroupExpenses_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 3 || e.Column.Index == 0)
            {
                long val1 = 0;
                long val2 = 0;

                if (e.CellValue1 != null)
                    long.TryParse(e.CellValue1.ToString().Replace("₫", "").Replace(".", "").Replace(",", ""), out val1);
                if (e.CellValue2 != null)
                    long.TryParse(e.CellValue2.ToString().Replace("₫", "").Replace(".", "").Replace(",", ""), out val2);

                e.SortResult = val1.CompareTo(val2);
                e.Handled = true;  // Handle only Spend and Earn
            }
            isSaved = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            file.SaveFrom(GroupExpenses);
            MessageBox.Show("Saved successfully");
            Calculate();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show(
                "Save your changes to this file?",
                "File Not Saved",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    file.SaveFrom(GroupExpenses);
                }
            }
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}