using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        public Dictionary<string, Character> keyValuePairs = new Dictionary<string, Character>();


        public Character GetClass(string key)
        {
            Character character = null;

            if (keyValuePairs.ContainsKey(key))
            {
                character = keyValuePairs[key];
            }
            else
            {
                switch (key)
                {
                    case "A":
                        character = new ClassA();
                        break;
                    case "B":
                        character = new ClassB();
                        break;
                    default:
                        break;

                }
            }

            return character;

        }
    }
}
