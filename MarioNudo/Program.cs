using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            Console.WriteLine("Пиццерия MarioNudo");
            #region Pizza
            Console.WriteLine("Чтобы сделать заказ, введите номер пиццы из списка меню:"
                              + "\n1. Пицца Карбонара"
                              + "\n2. Пицца Маргарита"
                              + "\n3. Пицца Пепперони");
            
           var num = Console.ReadKey();
            
            while (num.Key != ConsoleKey.NumPad1 && num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.NumPad3
                  && num.Key != ConsoleKey.D1 && num.Key != ConsoleKey.D2 && num.Key != ConsoleKey.D3)
            {
                Console.WriteLine("\rТакого номера в меню нет! Повторите заказ, пожалуйста.");
                num = Console.ReadKey();
            }


            if (num.KeyChar == '1')
            {
                pizza = new CarbonaraPizza();
                Console.WriteLine("\rПицца Карбонара ");
            }
            if (num.KeyChar == '2')
            {
                pizza = new MargaritaPizza();
                Console.WriteLine("\rПицца Маргарита ");
            }
            if (num.KeyChar == '3')
            {
                pizza = new PepperoniPizza();
                Console.WriteLine("\rПицца Пепперони ");
            }
            #endregion

            #region pizza additives
            Console.WriteLine("Можете сделать пиццу еще вкуснее! Введите номер добавки к пицце из списка меню:");
            Console.WriteLine("1. Оливки"
                                  + "\n2. Острый перец"
                                  + "\n3. Итальянский томатный соус"
                                  + "\n0. Без добавок");
            bool f = false;
            do
            {
                if (f) {
                    Console.WriteLine("\rВыбирайте добавку:");
                }
                f = true;
                num = Console.ReadKey();
                
                while (num.Key != ConsoleKey.NumPad0 && num.Key != ConsoleKey.NumPad1 && num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.NumPad3
                      && num.Key != ConsoleKey.D0 && num.Key != ConsoleKey.D1 && num.Key != ConsoleKey.D2 && num.Key != ConsoleKey.D3)
                {
                    Console.WriteLine("\rТакой добавки в меню нет! Повторите заказ, пожалуйста.");
                    num = Console.ReadKey();
                }

                if (num.KeyChar == '1')
                {
                    pizza = new BlackOlive(pizza);
                    Console.WriteLine("\r + Оливки");
                }
                if (num.KeyChar == '2')
                {
                    pizza = new HotPapper(pizza);
                    Console.WriteLine("\r + Острый перец");
                }
                if (num.KeyChar == '3')
                {
                    pizza = new Tomatoes(pizza);
                    Console.WriteLine("\r + Итальянский томатный соус");
                }
                Console.WriteLine("Еще добавки? \n1.Да, конечно! 2.Нет, спасибо!");
                num = Console.ReadKey();
                
            }
            while (num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.D2);
            #endregion
            Console.WriteLine("\rЗаказ:");
            Console.WriteLine("Название: {0}", pizza.Name);           
            Console.WriteLine("Ингридиенты: ");
            foreach (string i in pizza.GetIngredients())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Цена: {0}", pizza.GetPrice());
            Console.WriteLine("Приятного аппетита!");
            Console.ReadLine();
        }
    }
}
