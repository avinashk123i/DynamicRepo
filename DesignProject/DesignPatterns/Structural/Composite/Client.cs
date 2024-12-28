using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public class Client
    {
        
        

        public void DoOperation1(Iclient client)
        {
            Console.WriteLine(client.DoOperation());

        }

        public void DoOperation2(Iclient client2, Iclient client) {

            if (client.isComposite())
            {
                client.Add(client2);
            }

            client.DoOperation();
        }

    }
}

