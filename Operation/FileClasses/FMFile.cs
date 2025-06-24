using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Login.Page
{
    //FM: Financial Management
    internal class FMFile:AppFile
    {
        public FMFile()
        {
            fullpath = "";
        }
        public FMFile(string path)
        {
            fullpath = path;
        }
        public override void SaveFrom(DataGridView table)
        {
            using (var writer = new StreamWriter(fullpath))
            {
                foreach (DataGridViewRow row in table.Rows)
                {
                    if (!row.IsNewRow) // skip the new row placeholder
                    {
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            var value = row.Cells[i].Value?.ToString()?.Replace(",", ""); // Optional: sanitize commas
                            writer.Write(value);
                            if (i < table.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
        public override void LoadToTable(DataGridView table)
        {
            table.Rows.Clear();
            using (var reader = new StreamReader(fullpath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    int rowIndex = table.Rows.Add();

                    for (int i = 0; i < values.Length; i++)
                    {
                        if ((i == 2 || i == 3) && long.TryParse(values[i], out long num))
                            table.Rows[rowIndex].Cells[i].Value = num;
                        else
                            table.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }
            }
        }
    }
}
