using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Proxy
{
    public class Subject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("Did Something");
        }
    }
}
