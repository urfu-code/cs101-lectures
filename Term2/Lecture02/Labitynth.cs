using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    enum Space
    {
        NotVisited,
        Visited,
        Wall
    }

    class Labirynth
    {
        public static Space[,] CreateLarge()
        {
            return new Space[10000, 10000];
        }


       public static Space[,] CreateLabirynth()
        {
            var s = @"
 ##   #   
 #### # # 
      # # 
## #### # 
##       #
## ##### #
       # #
 # ### # #
 #   # # #
 # # # ###";
            var l = s.Split('\n');
            var map = new Space[10, 10];
            for (int x = 0; x < 10; x++)
                for (int y = 0; y < 10; y++)
                {
                    map[x, y] = l[x+1][y] == '#' ? Space.Wall : Space.NotVisited;
                }
            return map;
        }
    }