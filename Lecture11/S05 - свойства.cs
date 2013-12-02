using System;

namespace Slide05
{

    class Employee
    {
        private double salary; // приватные поля, как и переменные, следует писать с маленькой буквы

        //public void SetSalary(double salary)
        //{
        //    if (salary < 0) throw new ArgumentException(""); //так мы сигнализируем об ошибке
        //    Salary = salary;
        //}

        //public double GetSalary()
        //{
        //    return Salary;
        //}

        public double Salary //Свойства - это фактически пара геттера и сеттера
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0) throw new ArgumentException(); // value - это ключевое слово, используется внутри сеттера и означает присваиваемое значение
                salary = value; 
            }
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.Salary = -1000; //Так по-прежнему нельзя, поскольку сеттер свойства проверяет корректность значения

            Console.WriteLine(emp.Salary);

            emp.Salary = emp.Salary * 2;
            emp.Salary *= 2;

            //Таким образом, свойство - это возможность работать с парой методов с тем же синтаксисом, что и с полем.

        }
    }
}