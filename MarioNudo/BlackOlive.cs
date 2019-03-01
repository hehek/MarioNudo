using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class BlackOlive: PizzaDecorator
    {
        public BlackOlive(Pizza p): base(p, p.Name)
         { }

       
        public override List<string> GetIngredients()
        {
            var list = pizza.GetIngredients();
            string add = "оливки";
            if (list.Contains(add))
            {
                list.Remove(add);
                list.Add("оливки x2");
            }
            else
            {
                list.Add(add);
            }
            return list;
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 5;
        }
    }
}
