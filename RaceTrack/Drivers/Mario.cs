using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Mario : Driver
    {
        public Mario(RaceCar car) : base(car)
        {
            Name = "Mario";
            SkillLevel = 12;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
