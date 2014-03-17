using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    class S06 : Form
    {
        Timer timer; 
        public S06()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timerTick;
            timer.Start();

            Paint += S05_Paint;

            ResizeRedraw = true;
  
        }

        int counter = 1;

        void S05_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
            graphics.RotateTransform(counter * 5);
            graphics.ScaleTransform(counter * 10, counter * 10);

            graphics.FillRectangle(
                new SolidBrush(Color.Coral),
                - 1,
                - 1,
                2,
                2);
        }

       


        void timerTick(object sender, EventArgs e)
        {
            if (counter < 12)
                counter++;
            else
                timer.Stop();
            Invalidate();
        }

      

     
    }
}
