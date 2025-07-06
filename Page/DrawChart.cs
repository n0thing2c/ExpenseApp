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
        public void drawPieChart(Dictionary<string, long> categoryExpenses)
        {
            long total = categoryExpenses.Values.Sum();
            if (total == 0)
            {
                MessageBox.Show("No data to display.");
                return;
            }

            Chart pieChart = new Chart();
            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);
            chartArea.Position = new ElementPosition(20, 10, 60, 60);

            Title chartTitle = new Title
            {
                Text = "Spend Money Chart",
                Font = new System.Drawing.Font("Microsoft New Tai Lue", 17, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Crimson,
                Alignment = System.Drawing.ContentAlignment.TopCenter
            };
            pieChart.Titles.Add(chartTitle);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false
            };
            series.Label = " ";  //Turn off labels on chart
            pieChart.Series.Add(series);

            foreach (var category in categoryExpenses)
            {
                double percentage = (category.Value / (double)total) * 100;
                //Add points
                series.Points.AddXY(category.Key, category.Value);

                //Set legend text to show category and percentage
                series.Points[series.Points.Count - 1].LegendText = $"{category.Key} - {percentage:0.00}%";
            }

            Legend legend = new Legend
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                Font = new System.Drawing.Font("Microsoft New Tai Lue", 10, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.Crimson
            };
            legend.Title = "Categories";
            legend.Position = new ElementPosition(0, 70, 100, 30);
            pieChart.Legends.Add(legend);

            this.Controls.Add(pieChart);
            pieChart.Dock = DockStyle.Fill;
        }
    }
}
