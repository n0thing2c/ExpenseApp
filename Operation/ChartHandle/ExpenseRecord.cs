using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login.Operation.ChartHandle
{
    public class ExpenseRecord
    {
        private string category;
        private long money;
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
                        money = string.IsNullOrEmpty(values[2]) ? 0 : long.Parse(values[2])
                    };
                    if(rec.money > 0)
                    {
                        records.Add(rec);
                    }
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
                    categoryExpenses[record.category] += record.money;
                }
                else
                {
                    categoryExpenses[record.category] = record.money;
                }
            }
            return categoryExpenses;
        }
    }
    
}
