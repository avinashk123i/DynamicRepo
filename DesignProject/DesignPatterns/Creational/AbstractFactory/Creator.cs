using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory
{
    public interface Creator
    {
        public IproductA getProductA();

        public IproductB GetProductB();
    }
}
