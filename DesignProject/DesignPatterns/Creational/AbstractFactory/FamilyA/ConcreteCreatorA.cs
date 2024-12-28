using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory.FamilyA
{
    public class ConcreteCreatorA : Creator
    {
        public IproductA getProductA()
        {
            return new ProductA();  
        }

        public IproductB GetProductB()
        {
            return new ProductB3();
        }
    }
}
