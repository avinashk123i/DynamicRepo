using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.Singleton
{
    public class Singleton
    {

        public static object lockobj = new object();

        private Singleton()
        {
        }

        private static Singleton? instance;

        public static Singleton Instance
        {
            get
            {
                lock (lockobj)
                {

                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }

        public void WriteSingleton()
        {
            Console.WriteLine("Singleton1 Instantiated..");
        }

    }
}
