using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity
{
    public class FiveHundredNoteDispenser : IHandler
    {
        private IHandler _handler;
        public void DispenseCash(int cash)
        {
            var noteCount = cash / 500;
            Console.WriteLine($"Dispensed {noteCount} notes of five hundred");

            if ((cash - (noteCount * 500) != 0))
            {
                _handler.DispenseCash(cash - (noteCount * 500));
            }
        }

        public void SetNext(IHandler handler)
        {
            _handler = handler;
        }
    }
}
