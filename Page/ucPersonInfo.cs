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
    public partial class ucPersonInfo : UserControl
    {
        public Action<string> AddColumn;
        public List<string> names;
        public string personname;
        public ucPersonInfo()
        {
            InitializeComponent();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            personname = PersonName.Text;
            if(names.Contains(personname))
            {
                MessageBox.Show("Name already exist !", "Existed Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(personname=="")
            {
                MessageBox.Show("Name can not be empty !", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AddColumn?.Invoke(personname);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
