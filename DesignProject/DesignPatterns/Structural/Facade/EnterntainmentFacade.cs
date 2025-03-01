using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class EnterntainmentFacade
    {
        private readonly Projector _projector;
        private readonly Television _television;
        public EnterntainmentFacade(Projector projector, Television television)
        {
            _projector = projector;
            _television = television;
        }

        public void TvOn()
        {
            _projector.AdjustBrightness("100");
            _television.ShowMovie("Inception");
        }

        public void TvOff() { 
        
            _projector.AdjustBrightness("0");
            _television.ShowMovie("tvoff");
        
        }


    }
}
