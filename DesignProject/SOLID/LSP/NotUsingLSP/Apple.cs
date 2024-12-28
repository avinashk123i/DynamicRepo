using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.SOLID.LSP.NotUsingLSP
{
    public class Apple
    {
        public virtual void GetColor()
        {
            Console.WriteLine("Red");
        }
    }

    /// <summary>
    ///  It will return Orange for Apple's reference variable
    /// </summary>
    public class Orange : Apple
    {
        public override void GetColor()
        {
            Console.WriteLine("Orange");
        }
    }
}
