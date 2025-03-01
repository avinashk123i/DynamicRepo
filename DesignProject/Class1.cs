using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    public class Class1
    {


        
        public void GetFrequency(string data)
        {
            Dictionary<char, int> chardict = new Dictionary<char, int>();


            foreach (char c in data)
            {
                if (char.IsLetter(c))
                {

                    if (chardict.ContainsKey(c))
                    {
                        chardict[c]++;
                    }
                    else
                    {
                        chardict[c] = 1;
                    }

                }

            }


            foreach(var items in chardict)
            {
                Console.Write(items.Key + " " + items.Value);
            }

        }






    }
}
