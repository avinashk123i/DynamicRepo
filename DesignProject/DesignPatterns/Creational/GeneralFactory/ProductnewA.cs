using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Abstract
{
    public class ProductnewA : IProductNew
    {
        public int testA { get; set; }

        public string Operation()
        {
            return this.testA.ToString();
        }
    }
}
