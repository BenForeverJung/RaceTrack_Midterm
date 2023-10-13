using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Vette : RaceCar
    {
        public Vette()
        {
            Name = "Vette";
            TopSpeed = 125;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is all gas, no brakes!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} kills the ignition");
        }
    }
}
