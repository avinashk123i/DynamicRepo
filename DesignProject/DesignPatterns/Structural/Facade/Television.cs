using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class Television
    {

        public void ShowMovie(string movieName)
        {
            Console.WriteLine($"Showing the movie named: {movieName}");
        }

    }
}
