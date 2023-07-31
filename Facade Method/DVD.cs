using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Method
{
    public class DVD
    {
        public void TurnedOn()
        {
            Console.WriteLine("DVD turned on...");
        }
        public void TurnedOff()
        {
            Console.WriteLine("DVD turned off...");
        }
        public void Play()
        {
            Console.WriteLine("DVD is playing...");
        }
    }
}
