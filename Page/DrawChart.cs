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
                Font = new Font("Microsoft New Tai Lue", 17, FontStyle.Bold),
                ForeColor = Color.Crimson,
                Alignment = ContentAlignment.TopCenter
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
                if(category.Value <= 0) 
                    continue;

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
                Font = new Font("Microsoft New Tai Lue", 10, FontStyle.Regular),
                ForeColor = Color.Crimson
            };
            legend.Title = "Categories";
            legend.Position = new ElementPosition(0, 70, 100, 30);
            pieChart.Legends.Add(legend);

            this.Controls.Add(pieChart);
            pieChart.Dock = DockStyle.Fill;
        }

        public void drawLineChart(Dictionary<string, long> monthlyExpense)
        {
            Chart lineChart = new Chart();
            ChartArea chartArea = new ChartArea();

            chartArea.AxisX.Title = "Month-Year";
            chartArea.AxisY.Title = "Expense";
            chartArea.AxisX.TitleFont = new Font("Microsoft New Tai Lue", 12, FontStyle.Bold);
            chartArea.AxisY.TitleFont = new Font("Microsoft New Tai Lue", 12, FontStyle.Bold);
            chartArea.AxisX.TitleForeColor = Color.Crimson;
            chartArea.AxisY.TitleForeColor = Color.Crimson;

            chartArea.AxisX.LabelStyle.Font = new Font("Microsoft New Tai Lue", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Font = new Font("Microsoft New Tai Lue", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Format = "{0:0,0}";

            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            lineChart.ChartAreas.Add(chartArea);

            Title chartTitle = new Title
            {
                Text = "Monthly Savings Chart",
                Font = new Font("Microsoft New Tai Lue", 17, FontStyle.Bold),
                ForeColor = Color.Crimson,
                Alignment = ContentAlignment.TopCenter
            };
            lineChart.Titles.Add(chartTitle);

            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Crimson,
                Font = new Font("Microsoft New Tai Lue", 10, FontStyle.Bold),
                LabelFormat = "{0:0,0}",
                Color = Color.DarkSalmon
            };
            lineChart.Series.Add(series);

            foreach (var month in monthlyExpense)
            {
                series.Points.AddXY(month.Key, month.Value);
                series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
                series.Points[series.Points.Count - 1].MarkerSize = 7;
                if(month.Value > 0)
                {
                    series.Points[series.Points.Count - 1].LabelForeColor = Color.DarkGreen;
                }
            }

            this.Controls.Add(lineChart);
            lineChart.Dock = DockStyle.Fill;
        }
    }
}
