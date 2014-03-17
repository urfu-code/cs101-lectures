using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture04
{
    static class S01
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main1()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form();
            form.Text = "Hello, world";

            var button = new Button();
            button.Text = "Click me";
            button.Left = 100;
            button.Top = 100;
            button.Click += (sender, e) =>
                {
                    MessageBox.Show("Button is clicked");
                    form.Close();
                };

            form.Controls.Add(button);

            Application.Run(form);

        }

       
    }
}
