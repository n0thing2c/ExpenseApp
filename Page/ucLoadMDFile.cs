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
            file.LoadTotable(GroupExpenses);
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
            DataGridViewTextBoxColumn personres=new DataGridViewTextBoxColumn();
            personres.HeaderText = name;
            Result.Columns.Add(personres);
            //re-calculate result
            Calculate();
        }
        private void AddpersonButton_Click(object sender, EventArgs e)
        {
            ucPersonInfo psi = new ucPersonInfo();
            psi.AddColumn += AddPerson;
            this.Controls.Add(psi);
            psi.Location = new Point((psi.Parent.Width - psi.Width) / 2,
                                    (psi.Parent.Height - psi.Height) / 2);
            psi.BringToFront();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            file.SaveFrom(GroupExpenses);
            MessageBox.Show("Saved successfully");
            Calculate();
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
                    if (!long.TryParse(e.FormattedValue.ToString().Replace(".", "").Replace(",", ""), out _))
                    {
                        MessageBox.Show("Invalid number, please enter again");
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void GroupExpenses_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if ((e.ColumnIndex == 3) && e.Value is string str)
            {
                if (long.TryParse(str.Replace(".", ""), out long number))
                {
                    e.Value = number; // Store raw number
                    e.ParsingApplied = true;
                }
            }
        }

        private void GroupExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 3) && e.Value != null)
            {
                if (e.Value is long Value)
                {
                    e.Value = Value.ToString("N0", new CultureInfo("de-DE"));
                    e.FormattingApplied = true;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        
        private void Calculate()
        {
            //make name list and balance list for each person in the table
            double[] res =new double[numofpeople];
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
                        if (Convert.ToBoolean(row.Cells[i+4].Value)==true)
                        {
                            numofborrower++;
                        }   
                    }
                    //if no one borrows, decrease the spender balance
                    if(numofborrower==0)
                    {
                        res[spenderidx] -= spend;
                    }
                    //decrease balance of borrowers
                    for (int i = 0; i < numofpeople; i++)
                    {
                        if (Convert.ToBoolean(row.Cells[i+4].Value) == true)
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
                if (res[i] >= 0)
                    Result.Columns[i].DefaultCellStyle.BackColor = Color.Green;
                else
                    Result.Columns[i].DefaultCellStyle.BackColor = Color.Maroon;
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
            Result.ReadOnly = true;
            var culture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.InvariantCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ",";
            culture.NumberFormat.NumberGroupSeparator = ".";

            // Apply format for double

            Result.DefaultCellStyle.Format = "#,0.00";
            Result.DefaultCellStyle.FormatProvider = culture;
            //Calculate result
            Calculate();
        }

        private void GroupExpenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calculate();
        }
    }
}
