using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    class S02 : Form
    {
        public S02()
        {
            var button = new Button();
            button.Text = "Click me";
            button.Click+=(sender,args) =>
                {
                    Close();
                };
            this.Controls.Add(button);
        }
    }
}
