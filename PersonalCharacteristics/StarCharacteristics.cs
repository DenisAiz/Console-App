using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.SpaceObjects;

namespace Task3.PersonalCharacteristics
{
    class StarCharacteristics
    {
        public void ReadAdditional(Shape spaceObjects)
        {
            var star = spaceObjects as Star;

            Console.Write("Количество лет: ");

            int numberOfYears = Convert.ToInt32(Console.ReadLine());
            star.NumberOfYears = numberOfYears;
        }
    }
}
