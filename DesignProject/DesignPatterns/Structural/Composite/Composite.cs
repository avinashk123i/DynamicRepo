using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public class Composite : Iclient
    {

        private List<Iclient > _clients = new List<Iclient>();  
        public override string DoOperation()
        {
            string data = string.Empty;
            
            foreach (var client in _clients) {

                data += client.DoOperation();

            }

            return data;
        }

        public override bool isComposite()
        {
            return true;
        }

        public override void Add(Iclient client)
        {
            _clients.Add(client);
        }


        public override void Remove(Iclient client) {

            _clients.Remove(client);
        }
    }
}
