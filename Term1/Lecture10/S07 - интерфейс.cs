using System;
using System.Collections.Generic;

namespace Slide07
{
    /* Интерфейс - это требование к классу.
     * Например, этот интерфейс означает: чтобы класс считался геометрической фигурой, он должен уметь возвращать периметр
     */
    public interface IGeometry
    {
        double GetPerimeter();
    }


    public class Rectangle : IGeometry //В этой строчке мы сообщаем, что Rectangle - это геометрия, и обещаем реализовать GetPerimeter
    {
        public double X, Y, Width, Height;


        public double GetPerimeter() //Если мы не реализуем этот метод, то получим ошибку компиляции
        {
            return 2 * Width + 2 * Height;
        }
    }

    public class Circle : IGeometry
    {
        public double X, Y, R;


        public double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var geometries = new List<IGeometry>(); //я создаю массив каких-то, неважно каких, геометрических фигур
            geometries.Add(new Rectangle { Width = 100, Height = 50 });
            geometries.Add(new Circle { R = 10 });
            foreach (var e in geometries)
                Console.WriteLine(e.GetPerimeter());
        }
    }
}