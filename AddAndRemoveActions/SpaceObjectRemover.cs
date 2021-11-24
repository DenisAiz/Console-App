using System;
using System.Collections.Generic;
using Task3.Space;

namespace Task3.AddAndRemoveActions
{
    class SpaceObjectRemover
    {
        public List<SpaceObject> Remove(List<SpaceObject> spaceObjects)
        {
            Console.Write("Enter the name: ");

            string objectName = Console.ReadLine();

            var item = spaceObjects.Find(spaceObject => spaceObject.Name == objectName);

            spaceObjects.Remove(item);

            return spaceObjects;
        }
    }
}
