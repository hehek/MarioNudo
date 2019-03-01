using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class MargaritaPizza: Pizza
    {
        public MargaritaPizza() : base("Пицца Маргарита")
        { }

        public override List<string> GetIngredients()
        {
            var ingredientsList = new List<string>() { "сыр Моцарелла", "базилик", "оливковое масло",
                                                       "орегано", "итальянский томатный соус" };
            return ingredientsList;
        }

        public override int GetPrice()
        {
            return 49;
        }
    }
}
