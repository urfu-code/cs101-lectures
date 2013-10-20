using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Slide01
{
    public class Program
    {
        static Random random = new Random();

        #region Линейный поиск

        static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(int.MaxValue);
            return array;
        }

        static int LinearSearch(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element) return i;
            return -1;
        }

        public static void Main0()
        {
            var array = GenerateArray(100);
            Console.WriteLine(LinearSearch(array, array[40]));
        }
        #endregion

        #region Бинарный поиск

        static int[] GenerateSortedArray(int length)
        {
            var array = new int[length];
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i-1]+random.Next(10000)+1;
            return array;
        }



        static int BinarySearch(int[] array, int element)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var middle = (right + left) / 2;
                if (array[middle] == element) return middle;
                if (array[middle] < element) left = middle + 1;
                else right = middle - 1;
            }
            return -1;
        }

        static void Main1()
        {
            var array = GenerateSortedArray(100);
            Console.WriteLine(BinarySearch(array, array[49]));
        }

        #endregion

        #region Сравнение времени

        static void MeasureTime(int[] array, Func<int[], int, int> searchProcedure, Series series)
        {
            var repetitions = 100;
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < repetitions; i++)
                searchProcedure(array, array[random.Next(array.Length)]);
            watch.Stop();
            series.Points.Add(new DataPoint(array.Length, watch.ElapsedTicks / repetitions));
        }

        public static void Main2()
        {
            var linearGraph = new Series();
            var binaryGraph = new Series();
           
            for (int i = 100; i <= 100000; i *= 10)
            {
                GC.Collect();
                var array = GenerateSortedArray(i);
                MeasureTime(array, LinearSearch, linearGraph);
                MeasureTime(array, BinarySearch, binaryGraph);
            }

            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());
            
            linearGraph.ChartType = SeriesChartType.FastLine;
            linearGraph.Color = Color.Red;
            linearGraph.MarkerBorderWidth = 3;

            binaryGraph.ChartType = SeriesChartType.FastLine;
            binaryGraph.Color = Color.Green;
            binaryGraph.BorderWidth = 3;

            chart.Series.Add(linearGraph);
            chart.Series.Add(binaryGraph);
            chart.Dock = System.Windows.Forms.DockStyle.Fill;
            var form = new Form();
            form.Controls.Add(chart);
            Application.Run(form);

        }
        #endregion
    }
}