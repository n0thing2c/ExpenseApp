using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Login.Page
{
    internal class AppFile
    {
        protected string fullpath;
        public AppFile()
        {
            fullpath = "";
        }
        public AppFile(string path)
        {
            fullpath = path;
        }
        public void SetPath(string path)
        {
            fullpath = path;
        }
        public string GetFullPath()
        {
            return fullpath;
        }
        public void Create(string path)
        {
            this.fullpath = path;
            try
            {
                // Create an empty CSV file
                File.WriteAllText(fullpath, string.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
        public virtual void LoadTotable(DataGridView table)
        {
            table.Rows.Clear();
            using (var reader = new StreamReader(fullpath))
            {
                while (!reader.EndOfStream)
                {
                    /*
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    table.Rows.Add(values);
                    */
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
            //Format
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
        }
        public virtual void SaveFrom(DataGridView table)
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
    }
}
