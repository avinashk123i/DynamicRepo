using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.Singleton.NoLockThreadSafeSingleton
{
    public sealed class Singleton2
    {
        private static readonly Singleton2 Instance = new Singleton2();

        // Static Constructors only intializes once per domain 
        static Singleton2() { }
        private Singleton2() { }
        public static Singleton2 instance
        {
            get
            {
                return Instance;
            }
        }

    }
}
