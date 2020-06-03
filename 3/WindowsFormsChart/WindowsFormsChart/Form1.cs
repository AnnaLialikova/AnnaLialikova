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

namespace WindowsFormsChart
{
    public partial class Form1 : Form
    {
        static int k = 10;
        dat dl = new dat(k);

        public void chartPlot(int d, string leg)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 1; i<=k; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, dl.random(d));
            }
            if (checkBox1.Checked == true)
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
            }
            //chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
            //chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].LegendText = leg;
        }

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= k; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, dl.random(10));
                //chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
                //chart1.Series["Series1"].IsValueShownAsLabel = true;
                //chart1.Series["Series1"].LegendText = "Ветер м/с";
            }
            chart1.Series["Series1"].LegendText = "Ветер м/с";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                chartPlot(100, "Влажность");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                chartPlot(30, "Температура");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
            }
        }
    }
}
