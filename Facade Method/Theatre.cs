using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Method
{
    public class Theatre
    {
        private DVD dvd = new DVD();
        private Projector projector = new Projector();
        private SoundSystem soundSystem = new SoundSystem();

        public Theatre()
        {
            dvd=new DVD();
            projector=new Projector();
            soundSystem=new SoundSystem();
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("The movie has started...");
            dvd.TurnedOn();
            projector.TurnOn();
            soundSystem.TurnedOn();
            projector.setInput("DVD");
            dvd.Play();
            soundSystem.SetVolume("25");
            Console.WriteLine($"Enjoy the movie {movie}");

        }
        public void EndMovie()
        {
            Console.WriteLine("The movie has ended...");
            dvd.TurnedOff();
            projector.TurnOff();
            soundSystem.TurnedOff();

        }
    }
   
}
