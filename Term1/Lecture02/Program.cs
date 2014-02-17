using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture02
{
    static class Program
    {
        
        static void ControlMethod()
        {
            Wait(1);
            while (true)
            {
                form.LightOn(Lights.Red);
                Wait(1);
                form.LightOn(Lights.Yellow);
                Wait(0.5);
                form.LightOff(Lights.Red);
                form.LightOff(Lights.Yellow);
                form.LightOn(Lights.Green);
                Wait(1);
                form.LightOff(Lights.Yellow);
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                Wait(0.1);
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                Wait(0.1); 
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                Wait(0.1);
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                Wait(0.1);
                form.LightOn(Lights.Green);
                Wait(0.1);
                form.LightOff(Lights.Green);
                form.LightOn(Lights.Yellow);
                Wait(1);
                form.LightOff(Lights.Yellow);
            }
        }

        static void Wait(double seconds) { Thread.Sleep((int)(seconds * 1000)); }

        static LightsForm form;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new LightsForm();
            new Action(ControlMethod).BeginInvoke(null, null);
            Application.Run(form);
        }
    }
}
