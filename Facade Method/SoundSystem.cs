using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Method
{
    public class SoundSystem
    {
        public void TurnedOn()
        {
            Console.WriteLine("Volume turned on...");
        }
        public void TurnedOff()
        {
            Console.WriteLine("Volume turned off...");
        }
        public void SetVolume(string setvolume)
        {
            Console.WriteLine($"Volume has set {setvolume}");
        }
    }
}
