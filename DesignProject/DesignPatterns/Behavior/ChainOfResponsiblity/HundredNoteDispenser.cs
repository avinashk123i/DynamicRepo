using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public class HundredNoteDispenser : IHandler
    {
        public void DispenseCash(int cash)
        {
            var noteCount = cash / 100;
            Console.WriteLine($"Dispensed {noteCount} notes of hundred");

            if((cash - noteCount * 100) != 0)
            {
                Console.WriteLine("Please provide amount in multiples of hundred only..");
            }

            Console.WriteLine("No other cash modes to dispensed");
        }

        public void SetNext(IHandler handler)
        {
            return;
        }
    }
}
