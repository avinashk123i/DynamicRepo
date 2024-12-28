using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public interface IHandler
    {
        public void SetNext(IHandler next);

        public void Handle(object request);
    }
}
