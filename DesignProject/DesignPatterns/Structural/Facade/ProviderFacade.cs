using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class ProviderFacade
    {
        private IPizza pizza;
        private IBread bread;

        public ProviderFacade()
        {
             pizza = new PizzaProvider();
             bread = new BreadProvider();
        }


        public void GetPizzaProvider()
        {
            pizza.GetPizza();
        }

        public void GetBreadProvider()
        {
            bread.GetBread();
        }
    }
}
