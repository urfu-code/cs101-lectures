using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S05
{
    class Timer
    {
        public int Interval { get; set; }
        public event Action<int> Tick;
        
        public void Start()
        {
            for (int i = 0; ; i++)
            {
                if (Tick!=null) Tick(i);
                Thread.Sleep(Interval);
            }
        }
    }

    public class Program
    {
        public static void Main()
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
