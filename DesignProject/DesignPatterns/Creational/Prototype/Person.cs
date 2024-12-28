using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Id { get; set; }

        public string name { get; set; }

        public Student student { get; set; }

        public Person ShallowClone()
        {
            return (Person)MemberwiseClone();

        }


        public Person DeepClone()
        {

            var clone = (Person)MemberwiseClone();
            clone.student = new Student(student.Id);
            clone.name = new string(name);

            return clone;

        }
    }
}
