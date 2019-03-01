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
            Console.WriteLine();
            while (num.Key != ConsoleKey.NumPad1 && num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.NumPad3
                  && num.Key != ConsoleKey.D1 && num.Key != ConsoleKey.D2 && num.Key != ConsoleKey.D3)
            {
                Console.WriteLine("Такого номера в меню нет! Повторите заказ, пожалуйста.");
                num = Console.ReadKey();
            }


            if (num.KeyChar == '1')
            {
                pizza = new CarbonaraPizza();
            }
            if (num.KeyChar == '2')
            {
                pizza = new MargaritaPizza();
            }
            if (num.KeyChar == '3')
            {
                pizza = new PepperoniPizza();
            }
            #endregion

            #region pizza additives
            Console.WriteLine("\nМожете сделать пиццу еще вкуснее! Введите номер добавки к пицце из списка меню:");
            
            do
            {
                Console.WriteLine("\n1. Оливки"
                                  + "\n2. Острый перец"
                                  + "\n3. Итальянский томатный соус"
                                  + "\n0. Без добавок");
                num = Console.ReadKey();
                Console.WriteLine();
                while (num.Key != ConsoleKey.NumPad0 && num.Key != ConsoleKey.NumPad1 && num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.NumPad3
                      && num.Key != ConsoleKey.D0 && num.Key != ConsoleKey.D1 && num.Key != ConsoleKey.D2 && num.Key != ConsoleKey.D3)
                {
                    Console.WriteLine("Такой добавки в меню нет! Повторите заказ, пожалуйста.");
                    num = Console.ReadKey();
                }

                if (num.KeyChar == '1')
                {
                    pizza = new BlackOlive(pizza);
                }
                if (num.KeyChar == '2')
                {
                    pizza = new HotPapper(pizza);
                }
                if (num.KeyChar == '3')
                {
                    pizza = new Tomatoes(pizza);
                }
                Console.WriteLine("Еще добавки? \n1.Да, конечно!\n2.Нет, спасибо!");
                num = Console.ReadKey();
                Console.WriteLine();
            }
            while (num.Key != ConsoleKey.NumPad2 && num.Key != ConsoleKey.D2);
            #endregion

            Console.WriteLine("\nНазвание: {0}", pizza.Name);
            Console.WriteLine("Цена: {0}", pizza.GetPrice());
            Console.WriteLine("Ингридиенты: ");
            foreach (string i in pizza.GetIngredients())
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
