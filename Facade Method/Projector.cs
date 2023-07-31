using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Method
{
    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector Turned On...");
        }
        public void TurnOff()
        {
            Console.WriteLine("Projector Turned Off...");
        }
        public void setInput(string input)
        {
            Console.WriteLine($"Input source set to {input}");
        }

    }
}
