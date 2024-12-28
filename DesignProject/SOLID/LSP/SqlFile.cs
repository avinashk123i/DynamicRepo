using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.SOLID.LSP
{
    public class Apple : Color
    {
        public void GetColor()
        {
            Console.WriteLine("Apple");
        }
    }


    public interface Color
    {
        public void GetColor(); 
    }


    public class Orange : Color
    {
        public void GetColor()
        {
            Console.WriteLine("Orange");
        }
    }


    // var color = new Apple() ;; color.getColor();
}
