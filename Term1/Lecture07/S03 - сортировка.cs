using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Slide03
{
    public class Program
    {
        static Random random = new Random();


        static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(int.MaxValue);
            return array;
        }


        static void BubbleSort(int[] array)
        {
             for (int i=0;i<array.Length;i++)
                 for (int j=0;j<array.Length-1;j++)
                     if (array[j] > array[j + 1])
                     {
                         var t = array[j + 1];
                         array[j + 1] = array[j];
                         array[j] = t;
                     }
        }



        #region Быстрая сортировка

        static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return;
            var pivot=array[end];
            var storeIndex=start;
            for (int i=start;i<=end-1;i++)
                if (array[i]<=pivot)
                {
                    var t=array[i];
                    array[i]=array[storeIndex];
                    array[storeIndex]=t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }

        static void HoareSort(int[] array)
        {
            HoareSort(array, 0, array.Length - 1);
        }


        public static void MainHoare()
        {
            var array = GenerateArray(10);
            HoareSort(array);
            foreach (var e in array)
                Console.WriteLine(e);


        }
        #endregion

        #region Сортировка слиянием

        static int[] temporaryArray;

        static void Merge(int[] array, int start, int middle, int end)
        {
            var leftPtr = start;
            var rightPtr = middle + 1;
            var length = end - start + 1;
            for (int i = 0; i < length; i++)
            {
                if ( rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
                {
                    temporaryArray[i] = array[leftPtr];
                    leftPtr++;
                }
                else
                {
                    temporaryArray[i] = array[rightPtr];
                    rightPtr++;
                }
            }
            for (int i = 0; i < length; i++)
                array[i + start] = temporaryArray[i];
        }

        static void MergeSort(int[] array, int start, int end)
        {
            if (start == end) return;
            var middle = (start + end) / 2;
            MergeSort(array, start, middle);
            MergeSort(array, middle + 1, end);
            Merge(array, start, middle, end);
      
        }

        static void MergeSort(int[] array)
        {
            temporaryArray = new int[array.Length];
            MergeSort(array, 0, array.Length - 1);
        }

        public static void MainMerge()
        {
            var array = GenerateArray(10);
            MergeSort(array);
            foreach (var e in array)
                Console.WriteLine(e);
        }


        #endregion

        #region Сравнение времени

        static void MeasureTime(int[] array, Action<int[]> sortProcedure, Series series)
        {
            Console.WriteLine("Length=" + array.Length);
            var repetitions = 10;
            var arrays=new int[repetitions][];
            for (int i=0;i<repetitions;i++)
                arrays[i]=array.ToArray();
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < repetitions; i++)
                sortProcedure(arrays[i]);
            watch.Stop();
            series.Points.Add(new DataPoint(array.Length, watch.ElapsedTicks / repetitions));
            GC.Collect();
        }

        public static void Main()
        {
            var bubble = new Series();
            var hoare = new Series();
            var merge = new Series();

            for (int i = 1000; i <= 10000; i += 1000)
            {
                var array = GenerateArray(i);
                MeasureTime(array, BubbleSort, bubble);
                MeasureTime(array, HoareSort, hoare);
                MeasureTime(array, MergeSort, merge);
            }

            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());

            bubble.ChartType = SeriesChartType.FastLine;
            bubble.Color = Color.Red;
            bubble.MarkerBorderWidth = 3;

            hoare.ChartType = SeriesChartType.FastLine;
            hoare.Color = Color.Blue;
            hoare.BorderWidth = 3;

            merge.ChartType = SeriesChartType.FastLine;
            merge.Color = Color.Green;
            merge.BorderWidth = 3;

            chart.Series.Add(bubble);
            chart.Series.Add(hoare);
            chart.Series.Add(merge);
            chart.Dock = System.Windows.Forms.DockStyle.Fill;
            var form = new Form();
            form.Controls.Add(chart);
            Application.Run(form);

        }
        #endregion
    }
}