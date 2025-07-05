using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Login.Operation.ChartHandle;

namespace Login.Page
{
    public partial class DrawChart : UserControl
    {
        private ExpenseRecord record;
        public DrawChart(ExpenseRecord rec)
        {
            record = rec;
            InitializeComponent();
        }
        public void drawChart(Dictionary<string, long> categoryExpenses)
        {
            long total = categoryExpenses.Values.Sum();
            if (total == 0)
            {
                MessageBox.Show("No data to display.");
                return;
            }

            Chart pieChart = new Chart();
            pieChart.Width = 400;
            pieChart.Height = 400;

            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            Title chartTitle = new Title
            {
                Text = "Spend Money Chart",
                Font = new System.Drawing.Font("Microsoft New Tai Lue", 20, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Crimson,
                Alignment = System.Drawing.ContentAlignment.TopCenter
            };
            pieChart.Titles.Add(chartTitle);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            pieChart.Series.Add(series);

            foreach (var category in categoryExpenses)
            {
                double percentage = (category.Value / (double)total) * 100;
                //Add points
                series.Points.AddXY(category.Key, category.Value);
                
                //Set labels show category and %
                series.Points[series.Points.Count - 1].Label = $"{category.Key} - {percentage:0.00}%";
            }

            this.Controls.Add(pieChart);
            pieChart.Dock = DockStyle.Fill;
        }
    }
}
