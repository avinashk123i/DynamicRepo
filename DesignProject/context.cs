using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    public class context
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<context2> context2s { get; set; }
    }
}
