using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioNudo
{
    abstract class Pizza
    {
        public string Name { get; protected set; }
        public Pizza(string name)
        {
           Name = name;
        }
        
        public abstract int GetPrice();
        public abstract List<string> GetIngredients();

    }
}
