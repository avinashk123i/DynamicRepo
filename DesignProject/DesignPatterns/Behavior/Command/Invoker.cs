using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Command
{
    public class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            this._command = command;
        }


        public void ExecuteAction()
        {
            _command.Execute();
        }
    }
}
