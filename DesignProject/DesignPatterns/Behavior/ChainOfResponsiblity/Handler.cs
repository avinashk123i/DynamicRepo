using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public abstract class Handler : IHandler
    {
        private  IHandler _handler;
        public void SetNext(IHandler next)
        {
            this._handler = next;
        }

       public void Handle(object request)
        {

            ProcessRequest(request);

            if (_handler != null)
            {
                this._handler.Handle(request);
            }

        }


        public abstract void ProcessRequest(object request);
    }
}
