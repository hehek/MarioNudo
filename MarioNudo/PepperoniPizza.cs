using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class PepperoniPizza: Pizza
    {
        public PepperoniPizza() : base("Пицца Пепперони")
        { }

        public override List<string> GetIngredients()
        {
            var ingredientsList = new List<string>() { "cыр", "салями Пепперони", "кукуруза", "острый перец",
                                                        "итальянский томатный соус" };
            return ingredientsList;
        }

        public override int GetPrice()
        {
            return 79;
        }
    }
}
