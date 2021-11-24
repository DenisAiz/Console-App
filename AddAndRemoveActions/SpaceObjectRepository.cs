using System.Collections.Generic;
using Task3.PersonalCharacteristics;
using Task3.Space;

namespace Task3.AddAndRemoveActions
{
    class SpaceObjectRepository
    {
        public List<SpaceObject> AddObject<T>(List<SpaceObject> spaceObjects) where T : SpaceObject, new()
        {
            T spaceObject = new();

            var factory = new SpaceObjectFactory();

            var star = new Star();
            var planet = new Planet();
            var asteroid = new Asteroid();
            var blackHole = new BlackHole();

            switch (spaceObject)
            {
                case Star:
                    factory.CreateFactory(star);
                    spaceObjects.Add(star);
                    break;
                case Planet:
                    factory.CreateFactory(planet);
                    spaceObjects.Add(planet);
                    break;
                case Asteroid:
                    factory.CreateFactory(asteroid);
                    spaceObjects.Add(asteroid);
                    break;
                case BlackHole:
                    factory.CreateFactory(blackHole);
                    spaceObjects.Add(blackHole);
                    break;
            }
            return spaceObjects;
        }
    }
}
