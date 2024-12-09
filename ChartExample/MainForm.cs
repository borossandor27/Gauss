using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. Alapbeállítások
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

            // 2. ChartArea hozzáadása
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "X tengely";
            chartArea.AxisY.Title = "Y tengely";
            chart.ChartAreas.Add(chartArea);

            // 3. Adatsor (Series) létrehozása
            Series series = new Series("Példa adatok");
            series.ChartType = SeriesChartType.Line;
            series.Color = System.Drawing.Color.Blue;
            series.BorderWidth = 2;
            chart.Series.Add(series);

            // 4. Adatok hozzáadása
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            series.Points.AddXY(4, 25);

            // 5. Legenda
            Legend legend = new Legend("MainLegend");
            chart.Legends.Add(legend);
        }
    }
}
