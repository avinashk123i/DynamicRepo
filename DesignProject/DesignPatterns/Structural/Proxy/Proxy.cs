using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private Subject _subject = new Subject();
        public void DoSomething()
        {
           _subject.DoSomething();
        }
    }
}
