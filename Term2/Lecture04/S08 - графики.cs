using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lecture04
{
    class S08 : Form
    {
        public S08()
        {
            
            var chart = new Chart()
            {
                ChartAreas = { new ChartArea() },
            };
            chart.Dock = DockStyle.Fill;
            Controls.Add(chart);


            var serie = new Series();
            for (double x = 0; x < 10; x++)
                serie.Points.Add(new DataPoint(x, x * x));
            serie.ChartType = SeriesChartType.FastLine;

            chart.Series.Add(serie);
        }
    }
}
