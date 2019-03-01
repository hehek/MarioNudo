using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class Tomatoes : PizzaDecorator
    {
        public Tomatoes(Pizza p) : base(p, p.Name)
        { }


        public override List<string> GetIngredients()
        {
            var list = pizza.GetIngredients();
            string add = "итальянский томатный соус";
            if (list.Contains(add))
            {
                list.Remove(add);
                list.Add("итальянский томатный соус x2");
            }
            else
            {
                list.Add(add);
            }
            return list;
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 4;
        }
    }
}
