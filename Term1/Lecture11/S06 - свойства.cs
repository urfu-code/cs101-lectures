using System;

namespace Slide06
{

    class CartItem //класс купленного товара
    {
        //Поля не должны быть публичными, это не comme il faut
        private double price;
        //Лучше делать свойство, пусть даже оно ничего, кроме присвоения поля, не делает
        public double Price { get { return price; } set { price = value; } }

        //Если свойство ничего, кроме присвоения, не делает, можно сделать автосвойство
        //следующая строчка
        public double Count { get; set; }
        // заставит компилятора сгенерировать текст:
        // private double count;
        // public double Count { get { return count; } set { count = value; } }

        // Свойство может быть вообще никак не связано с полем
        // Так, поля total в классе нет, но свойство Total есть, и возвращает произведение других свойств
        // Важно: свойство - это НЕ поле, НЕ данные! Свойство - это пара методов, которые по синтаксису ведут себя, как поле 
        public double Total
        {
            get { return Count * Price; }
        }

    }
}