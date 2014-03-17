using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    class S07 : Form
    {
        public S07()
        {
            var button = new Button();
            button.Text = "Click me";
            button.Click+=(sender,args) =>
                {
                    Thread.Sleep(10000);
                };
            this.Controls.Add(button);
        }
        
    }
}
