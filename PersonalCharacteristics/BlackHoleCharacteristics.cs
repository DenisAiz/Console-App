using System;
using Task3.SpaceObjects;

namespace Task3.PersonalCharacteristics
{
    class BlackHoleCharacteristics
    {
        public void ReadAdditional(Shape spaceObject)
        {
            var blackHole = spaceObject as BlackHole;

            Console.Write("Диаметр: ");

            int diameter = Convert.ToInt32(Console.ReadLine());
            blackHole.Diameter = diameter;
        }
    }
}
