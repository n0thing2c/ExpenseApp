using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
namespace Login.Page
{
    //MD: Money Divider
    internal class MDFile:AppFile
    {
        
        public MDFile()
        {
            fullpath = "";
        }
        public MDFile(string path)
        {
            fullpath = path;
        }
        public int GetNumberOfPeople()
        {
            if (File.Exists(fullpath))
            {
                var lines = File.ReadLines(fullpath);
                if (!lines.Any()) // file is empty
                    return 0;
                string firstLine = lines.First();
                string[] columns = firstLine.Split(',');
                return (columns.Length);
            }
            else
            {
                return 0;
            }
        }
        public List<string> PeopleList()
        {
            List<string> people = new List<string>();
            string[] lines = File.ReadAllLines(fullpath);
            if (lines.Length == 0)
                return people;

            // Split header line and add columns
            string[] headers = lines[0].Split(',');
            int i = 0;
            foreach (string header in headers)
            {
                people.Add(header);
                i++;
            }
            return people;
        }
        public override void SaveFrom(DataGridView table)
        {
            using (var writer = new StreamWriter(fullpath))
            {
                 for (int i = 4; i < table.Columns.Count - 1; i++)
                {
                    var header = table.Columns[i].HeaderText; // Optional: remove commas
                    writer.Write(header.Replace(","," "));
                    if (i < table.Columns.Count - 2)
                        writer.Write(",");
                }
                writer.WriteLine();
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
        public override void LoadTotable(DataGridView table)
        {
            string[] lines = File.ReadAllLines(fullpath);
            if (lines.Length == 0)
                return;

            // Split header line and add columns
            string[] headers = lines[0].Split(',');
            int idx = 4;
            foreach (string header in headers)
            {
                DataGridViewCheckBoxColumn personcol= new DataGridViewCheckBoxColumn(); 
                personcol.HeaderText = header;
                table.Columns.Insert(idx, personcol);
                idx++;
            }

            table.Rows.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] cells = lines[i].Split(',');
                int rowIndex = table.Rows.Add();
                for (int j = 0; j < cells.Length; j++)
                {
                    if ((j == 3) && long.TryParse(cells[j], out long num))
                        table.Rows[rowIndex].Cells[j].Value = num;
                    else if (j >= 4 && j < table.ColumnCount - 1)
                    {
                        if (cells[j] == "True")
                        {
                            table.Rows[rowIndex].Cells[j].Value = true;
                        }
                        else
                            table.Rows[rowIndex].Cells[j].Value = false;
                    }
                    else
                        table.Rows[rowIndex].Cells[j].Value = cells[j];
                }
            }
        }
    }
}
