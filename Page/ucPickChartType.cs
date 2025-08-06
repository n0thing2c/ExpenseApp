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
    public partial class ucPickChartType : UserControl
    {
        public EventHandler PieChart;
        public EventHandler LineChart;
        public EventHandler ExitClicked;
        public ucPickChartType()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PieChartButton_Click(object sender, EventArgs e)
        {
            PieChart?.Invoke(this, EventArgs.Empty);
        }

        private void LineChartButton_Click(object sender, EventArgs e)
        {
            LineChart?.Invoke(this, EventArgs.Empty);
        }
    }
}
