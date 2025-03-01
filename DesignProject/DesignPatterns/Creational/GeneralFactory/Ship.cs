using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Abstract
{
    public class Ship : Ilogistics
    {
        public string Deliver()
        {
            return "Delivering via Ship";
        }

    }
}
