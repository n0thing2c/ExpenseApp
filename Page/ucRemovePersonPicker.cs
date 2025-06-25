using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class ucRemovePersonPicker : UserControl
    {
        public Action<string> DeleteColumn;
        public List<string> names;
        public ucRemovePersonPicker()
        {
            InitializeComponent();
        }
        public void ShowListBox()
        {
            namelist.Items.Clear();
            foreach(string name in names)
            {
                namelist.Items.Add(name);
            }
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (namelist.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a person", "person not selected yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DeleteColumn?.Invoke(namelist.SelectedItem.ToString());
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
