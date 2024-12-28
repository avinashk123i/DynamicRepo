using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory.FamilyB
{
    public class ConcreteCreatorB : Creator
    {
        public IproductA getProductA()
        {
            return new ProductA3();
        }

        public IproductB GetProductB()
        {
            return new ProductB();
        }
    }
}
