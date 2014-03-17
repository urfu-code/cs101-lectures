using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    class S04 : Form
    {
        Timer timer; 
        public S04()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timerTick;
            timer.Start();
        }

        int counter = 0;

        //Не лучший способ!
        void timerTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();

            graphics.Clear(Color.White);
            graphics.FillEllipse(
                new SolidBrush(Color.Coral),
                ClientSize.Width / 2 - counter * 10,
                ClientSize.Height / 2 - counter * 10,
                2 * counter * 10,
                2 * counter * 10);
            if (counter < 12)

                counter++;

            else
                timer.Stop();
        }

      

     
    }
}
