using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class CarbonaraPizza: Pizza
    {
        public CarbonaraPizza() : base("Пицца Карбонара")
            { }

        public override List<string> GetIngredients()
        {
            var ingredientsList = new List<string>() { "бекон", "сыр Моцарелла", "сыр Дор-блю", "сыр Пармезан", "сливки",
                                                        "яйцо перепелиное", "перец чёрный молотый" };
            return ingredientsList;
        }

        public override int GetPrice()
        {
            return 69;
        }
    }
 }
