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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Report_Notification_Click(object sender, EventArgs e)
        {

        }

        private void Report_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending succesfully");
            Report_box.Clear();
        }
    }
}
