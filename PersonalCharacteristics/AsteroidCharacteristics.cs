using System;
using Task3.SpaceObjects;

namespace Task3.PersonalCharacteristics
{
    class AsteroidCharacteristics
    {
        public void ReadAdditional(Shape spaceObject)
        {
            var asteroid = spaceObject as Asteroid;

            Console.Write("Масса: ");

            int weight = Convert.ToInt32(Console.ReadLine());
            asteroid.Weight = weight;
        }
    }
}
