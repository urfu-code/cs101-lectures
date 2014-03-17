using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S03
{
    class Timer
    {
        private int interval;
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        private Action<int> tick;

        public event Action<int> Tick
        {
            add { tick += value; }
            remove { tick -= value; }
        }

        public void Start()
        {
            for (int i = 0; ; i++)
            {
                if (tick!=null) tick(i);
                Thread.Sleep(Interval);
            }
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var timer = new Timer();
            timer.Interval = 500;
            timer.Tick += tickNumber => Console.WriteLine(tickNumber);
           // timer.Tick = tickNumber => Console.WriteLine(tickNumber);
           // timer.Tick(100);
           // timer.tick(100);
            timer.Start();

        }
    }
}
