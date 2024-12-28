using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Flyweight
{
    public class ClassB : Character
    {
        public int Length { get; }
        public string Description { get; }

        public ClassB()
        {
            this.Length = 60;
            this.Description = "Class B characters";
        }

        public void display()
        {
            Console.WriteLine(Length + Description);
        }


    }
}
