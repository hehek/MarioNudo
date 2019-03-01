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



            Console.WriteLine("Название: {0}", pizza.Name);
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
