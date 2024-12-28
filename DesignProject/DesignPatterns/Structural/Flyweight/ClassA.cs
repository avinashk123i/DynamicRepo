using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Flyweight
{
    public class ClassA : Character
    {
        public int Length { get; }
        public string Description { get; }

        public ClassA()
        {
            this.Length = 50;
            this.Description = string.Empty;
        }

        public void display()
        {
            Console.WriteLine(Length + Description);
        }
    }
}
