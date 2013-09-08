using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture02
{
    public partial class LightsForm : Form
    {
        bool[] lights = new bool[3];

        protected override void OnPaint(PaintEventArgs e)
        {

            var D = Math.Min(ClientSize.Width, ClientSize.Height / 3);
            var colors = new Color[] { Color.Red, Color.Yellow, Color.Green };
            e.Graphics.Clear(Color.White);
            for (int i=0;i<3;i++)
                e.Graphics.FillEllipse(
                    new SolidBrush(lights[i]?colors[i]:Color.White), 
                    ClientSize.Width/2-D/2, 
                    i*ClientSize.Height/3+ClientSize.Height/6-D/2,
                    D,
                    D);
        }

        public void LightOn(Lights light)
        {
            lights[(int)light]=true;
            BeginInvoke(new Action(Invalidate));
        }


        public void LightOff(Lights light)
        {
            lights[(int)light]=false;
            BeginInvoke(new Action(Invalidate));
        }


    }
}
