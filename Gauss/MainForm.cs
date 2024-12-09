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

namespace Gauss
{
    public partial class MainForm : Form
    {
        double[] inputAdatok;
        double atlag;
        double szoras;
        double variancia;
        List<AdatOsztaly> osztalyok = new List<AdatOsztaly>();
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adadokBeolvasasa();
            //1.Átlag kiszámítása.
            atlag = inputAdatok.Average();
            //2.Eltérések az átlagtól.
            //3.Variancia és szórás meghatározása.
            variancia = inputAdatok.Select(x => (x - atlag) * (x - atlag)).Sum() / inputAdatok.Length;
            label_Variancia.Text = $"Variancia: {variancia.ToString("#,##0.00")}";
            szoras = Math.Sqrt(variancia);
            label_Szoras.Text = $"Szórás: {szoras.ToString("#,##0.00")}";
            //4.Osztályközök definiálása.
            double osztalyokSzama = Math.Ceiling((inputAdatok.Max() - inputAdatok.Min()) / Math.Sqrt(inputAdatok.Length));
            label_Osztalyok.Text = $"Osztályok: {osztalyokSzama}";
            double osztalyHossz = (inputAdatok.Max() - inputAdatok.Min()) / osztalyokSzama;
            for (int i = 0; i < osztalyokSzama; i++)
            {
                double min = inputAdatok.Min() + i * osztalyHossz;
                double max = min + osztalyHossz;
                osztalyok.Add(new AdatOsztaly(min, max));
            }
            //5.Frekvenciák vagy relatív gyakoriságok meghatározása.
            foreach (double adat in inputAdatok)
            {
                foreach (AdatOsztaly osztaly in osztalyok)
                {
                    if (adat >= osztaly.Min && adat < osztaly.Max)
                    {
                        osztaly.adatHozzaAd(adat);
                        break;
                    }
                }
            }
            //6.Normált eloszlás illesztése(ha szükséges).
            //7.Grafikon készítése.
            grafikonKeszites();
        }

        private void grafikonKeszites()
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
            Series series = new Series("Eloszlás adatok");
            series.ChartType = SeriesChartType.Spline;
            series.Color = System.Drawing.Color.Blue;
            series.BorderWidth = 2;
            chart.Series.Add(series);

            // 4. Adatok hozzáadása
            int points = inputAdatok.Length;
            double minX = inputAdatok.Min();
            label_Atlag.Text = $"Átlag: {atlag.ToString("#,##0.00")}";
            label_Min.Text = $"Min: {minX.ToString("#,##0.00")}";
            double maxX = inputAdatok.Max();
            label_Max.Text = $"Max: {maxX.ToString("#,##0.00")}";
            chartArea.AxisX.Minimum = minX;
            chartArea.AxisX.Maximum = maxX;
            chartArea.AxisX.Interval = (maxX - minX) / 10;
            double step = (maxX - minX) / points;
            // Normált eloszlás illesztése
            var densityData = Enumerable.Range(0, points + 1)
                    .Select(i =>
                    {
                        double x = minX + i * step;
                        double density = (1 / (szoras * Math.Sqrt(2 * Math.PI))) *
                                         Math.Exp(-Math.Pow(x - atlag, 2) / (2 * variancia));
                        return new { X = x, Density = density };
                    })
                    .ToArray();


            for (int i = 0; i < densityData.Length; i++)
            {
                series.Points.AddXY(densityData[i].X, densityData[i].Density);
            }
            // 2. Oszlop (Column) adatsor
            //Series columnSeries = new Series("Oszlop adatok");
            //columnSeries.ChartType = SeriesChartType.Column; // Oszlop diagram
            //columnSeries.Color = System.Drawing.Color.Red;
            //columnSeries.ChartArea = "MainArea"; // Ugyanaz a ChartArea
            //chart.Series.Add(columnSeries);
            //// Adatok hozzáadása az oszlop diagramhoz
            //foreach (AdatOsztaly osztaly in osztalyok)
            //{
            //    columnSeries.Points.AddXY(osztaly.Min, osztaly.relativGyakorisag(inputAdatok.Length));
            //}
            
            // 5. Legenda
            Legend legend = new Legend("MainLegend");
            chart.Legends.Add(legend);
        }

        private void adadokBeolvasasa()
        {
            // inputAdatok beolvasása a gauss.csv fájlból
            string[] sorok = System.IO.File.ReadAllLines("gauss.csv");
            inputAdatok = new double[sorok.Length];
            for (int i = 0; i < sorok.Length; i++)
            {
                inputAdatok[i] = double.Parse(sorok[i]);
            }
            //listBox_meresi_adatok.DataSource = inputAdatok;
            label_N.Text = $"N: {inputAdatok.Length.ToString()}";
        }
    }
}
