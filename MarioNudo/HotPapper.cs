using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    class HotPapper : PizzaDecorator
    {
        public HotPapper(Pizza p, string name) : base(p, name)
        { }


        public override List<string> GetIngredients()
        {
            var list = pizza.GetIngredients();
            string add = "острый перец";
            if (list.Contains(add))
            {
                list.Remove(add);
                list.Add("острый перец x2");
            }
            else
            {
                list.Add(add);
            }
            return list;
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 7;
        }
    }
}
