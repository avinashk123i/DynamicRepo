using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public class AuthenticationHandler : Handler
    {
        public override void ProcessRequest(object request)
        {
            Console.WriteLine("Authenticated request..");
        }
    }
}
