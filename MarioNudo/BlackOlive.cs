using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class BlackOlive: PizzaDecorator
    {
        public BlackOlive(Pizza p, string name): base(p, name)
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
                list.Add("оливки");
            }
            return list;
        }

        public override int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
