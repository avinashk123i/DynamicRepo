using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Adapter
{
    public class Adapter : IAdapter
    {
        private Adaptee? _adaptee;
        public void DoSomething()
        {
            _adaptee?.GetSomething();
        }
    }
}
