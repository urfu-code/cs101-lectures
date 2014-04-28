using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04
{
    struct Color
    {
        public int R;
        public int G;
        public int B;
    }

    class Bitmap
    {
        Color[,] pixels = new Color[100, 100];
        public Color this[int x, int y] { 
            get { return pixels[x, y]; } 
            set { pixels[x,y]=value;}
        }
    }

    class Program
    {

        public static void Main()
        {
            var bitmap = new Bitmap();
            Console.WriteLine(bitmap[0, 0].R);
            bitmap[0, 0] = new Color { R = 2, G = 3, B = 4 };
            var pixel=bitmap[0, 0];
            pixel.R++;
            Console.WriteLine(bitmap[0, 0].R);
            //bitmap[0, 0].R++;
        }
    }


}
