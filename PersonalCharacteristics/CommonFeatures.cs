using System;
using Task3.SpaceObjects;

namespace Task3.PersonalCharacteristics
{
    public class CommonFeatures : SpaceObject
    {
        public void Feature(SpaceObject spaceObject)
        {
            Console.Write("Название: ");
            spaceObject.Name = Console.ReadLine();

            Console.Write("Описание: ");
            spaceObject.Description = Console.ReadLine();
        }
        
        public void ReadFeature(Shape spaceObject)
        {
            Feature(spaceObject);            
        }
    }
}


