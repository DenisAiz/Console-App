using System;
using System.Collections.Generic;
using Task3.Space;

namespace Task3.PersonalCharacteristics
{
    public class SpaceObjectFactory
    {
        public void CreateGlobalFactory(SpaceObject spaceObject)
        {
            Console.Write("Name: ");
            spaceObject.Name = Console.ReadLine();

            Console.Write("Description: ");
            spaceObject.Description = Console.ReadLine();
        }

        public void CreateFactory(Asteroid asteroid)
        {
            CreateGlobalFactory(asteroid);

            Console.Write("Weight: ");

            asteroid.Weight = Convert.ToString(Console.ReadLine());
        }

        public void CreateFactory(BlackHole blackHole)
        {
            CreateGlobalFactory(blackHole);

            Console.Write("Diameter: ");

            blackHole.Diameter = Convert.ToString(Console.ReadLine());
        }

        public void CreateFactory(Planet planet)
        {
            CreateGlobalFactory(planet);

            Console.Write("Distance from Earth: ");

            planet.DistanceFromEarth = Convert.ToString(Console.ReadLine());
        }

        public void CreateFactory(Star star)
        {
            CreateGlobalFactory(star);

            Console.Write("Number of years: ");

            star.NumberOfYears = Convert.ToString(Console.ReadLine());
        }
    }
}



