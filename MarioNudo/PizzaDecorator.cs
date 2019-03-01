using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        private Pizza p;

      
        public PizzaDecorator(Pizza pizza, string name) : base(name)
        {
            this.pizza = pizza;
        }
    }
}
