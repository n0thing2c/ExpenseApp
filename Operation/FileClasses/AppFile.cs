using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Login.Page
{
    internal abstract class AppFile
    {
        protected string fullpath;
        
        public void SetPath(string path)
        {
            fullpath = path;
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
        public abstract void LoadToTable(DataGridView table);
        
        public abstract void SaveFrom(DataGridView table);
        
    }
}
