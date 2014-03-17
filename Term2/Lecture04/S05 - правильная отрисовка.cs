using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    class S05 : Form
    {
        Timer timer; 
        public S05()
        {
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timerTick;
            timer.Start();

            Paint += S05_Paint;

            ResizeRedraw = true;
  
        }
        
        //Должна быть объектная модель, полностью описывающее состояние приложения
        int counter = 0;

        //Все рисование - в обработчике события Paint
        void S05_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            graphics.FillEllipse(
                new SolidBrush(Color.Coral),
                ClientSize.Width / 2 - counter * 10,
                ClientSize.Height / 2 - counter * 10,
                2 * counter * 10,
                2 * counter * 10);
        }

        // Вызов Paint - через Invalidate       
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
