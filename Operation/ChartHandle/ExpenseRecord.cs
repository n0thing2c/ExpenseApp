using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Login.Operation.ChartHandle
{
    public class ExpenseRecord
    {
        private string category;
        private long spend;
        private long earn;

        public long expense()
        {
            return earn - spend;
        }
        public List<ExpenseRecord> ReadCSV(string filepath)
        {
            List<ExpenseRecord> records = new List<ExpenseRecord>();
            using (var reader = new StreamReader(filepath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    ExpenseRecord rec = new ExpenseRecord
                    {
                        category = values[1],
                        spend = string.IsNullOrEmpty(values[2]) ? 0 : long.Parse(values[2]),
                        earn = string.IsNullOrEmpty(values[3]) ? 0 : long.Parse(values[3])
                    };
                        records.Add(rec);
                }
            }
            return records;
        }
        public Dictionary<string, long> GetCategoryExpenses(List<ExpenseRecord> records)
        {
            Dictionary<string, long> categoryExpenses = new Dictionary<string, long>();
            foreach (var record in records)
            {
                if (categoryExpenses.ContainsKey(record.category))
                {
                    categoryExpenses[record.category] += record.spend;
                }
                else
                {
                    categoryExpenses[record.category] = record.spend;
                }
            }
            return categoryExpenses;
        }


        public Dictionary<string, long> GetMonthlyExpense(string[] CSVFiles)
        {
            ExpenseRecord expenseRecord = new ExpenseRecord();

            //Store expense of each file in folder
            Dictionary<string, long> monthlyExpense = new Dictionary<string, long>();
            foreach (var file in CSVFiles)
            {
                string month = Path.GetFileNameWithoutExtension(file).Split('_')[0];
                string year = Path.GetFileNameWithoutExtension(file).Split('_')[1];
                string monthYear = $"{month}{year}";

                if (!monthlyExpense.ContainsKey(monthYear))
                {
                    monthlyExpense[monthYear] = 0;
                }

                var records = expenseRecord.ReadCSV(file);
                foreach (var record in records)
                {
                    monthlyExpense[monthYear] += record.expense();
                }
            }

            //Sort the dictionary by month
            var sortedMonthlyExpense = monthlyExpense.OrderBy(x => DateTime.ParseExact(x.Key, "MMMMyyyy", CultureInfo.InvariantCulture)).ToDictionary(x => x.Key, x => x.Value);
            return sortedMonthlyExpense;
        }
    }
    
}
