using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public class TwoHundredNoteDispenser : IHandler
    {
        private IHandler _handler;
        public void DispenseCash(int cash)
        {
            var noteCount = cash / 200;
            Console.WriteLine($"Dispensed {noteCount} notes of two hundred");

            if ((cash - (noteCount * 200) != 0))
            {
                _handler.DispenseCash(cash - (noteCount * 200));
            }
        }

        public void SetNext(IHandler handler)
        {
            _handler = handler;
        }
    }
}
