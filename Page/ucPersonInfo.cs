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
        public string personname;
        public ucPersonInfo()
        {
            InitializeComponent();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            personname = PersonName.Text;
            AddColumn?.Invoke(personname);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
