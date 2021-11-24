using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.SpaceObjects;

namespace Task3.PersonalCharacteristics
{
    class PlanetCharacteristics
    {
        public void ReadAdditional(Shape spaceObject)
        {
            var planet = spaceObject as Planet;

            Console.Write("Расстояние до земли: ");

            int distanceFromEarth = Convert.ToInt32(Console.ReadLine());
            planet.DistanceFromEarth = distanceFromEarth;
        }
    }
}
