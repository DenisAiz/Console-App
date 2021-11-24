using System.Collections.Generic;
using System.Linq;
using Task3.PrinterObject;
using Task3.Space;

namespace Task3.FilterObject
{
    class PropertyPrinter 
    {
        public void PrintProperties<T>(List<SpaceObject> spaceObjects) where T : SpaceObject, new()
        {
            T spaceObject = new();

            var printerFactory = new Printer();

            switch (spaceObject)
            {
                case Star:

                    IEnumerable<Star> stars = spaceObjects.OfType<Star>();

                    foreach (var item in stars)
                    {
                        printerFactory.ShowPropertiesObject(item);
                    }
                    break;

                case Planet:

                    IEnumerable<Planet> planets = spaceObjects.OfType<Planet>();

                    foreach (var item in planets)
                    {
                        printerFactory.ShowPropertiesObject(item);
                    }
                    break;

                case Asteroid:

                    IEnumerable<Asteroid> asteroids = spaceObjects.OfType<Asteroid>();

                    foreach (var item in asteroids)
                    {
                        printerFactory.ShowPropertiesObject(item);
                    }
                    break;

                case BlackHole:

                    IEnumerable<BlackHole> blackHoles = spaceObjects.OfType<BlackHole>();

                    foreach (var item in blackHoles)
                    {
                        printerFactory.ShowPropertiesObject(item);
                    }
                    break;
            }
        }             
    }
}
