using System;
using System.Collections.Generic;
using Task3.FilterObject;
using Task3.Space;

namespace Task3.PrinterObject
{
    public class Printer : IPrinter
    {
        public void ShowObject(SpaceObject spaceObjects)
        {
            Console.WriteLine($"Name: {spaceObjects.Name}");

            Console.WriteLine($"Description: {spaceObjects.Description}");          
        }

        public void ShowPropertiesObject(Asteroid asteroid)
        {
            ShowObject(asteroid);

            Console.WriteLine($"Weight: {asteroid.Weight}\n");
        }

        public void ShowPropertiesObject(BlackHole blackHoles)
        {
            ShowObject(blackHoles);

            Console.WriteLine($"Diameter: {blackHoles.Diameter}\n");
        }

        public void ShowPropertiesObject(Planet planets)
        {
            ShowObject(planets);

            Console.WriteLine($"Distance from Earth: {planets.DistanceFromEarth}\n");
        }

        public void ShowPropertiesObject(Star stars)
        {
            ShowObject(stars);

            Console.WriteLine($"Number of years: {stars.NumberOfYears}\n");
        }
    }
}
