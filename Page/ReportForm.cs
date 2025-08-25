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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }


        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (usercontact.Text.Length == 0)
            {
                MessageBox.Show("Please enter your contact (email or phone number)", "No contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(bugtextbox.Text.Length==0)
            {
                MessageBox.Show("Please describe the bug", "Empty report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                MessageBox.Show("Report sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
