using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    public class context2
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<context> Children
        {
            get; set;
        }
    }
}
