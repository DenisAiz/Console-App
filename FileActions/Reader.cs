using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Task3.Space;

namespace Task3
{
    public class Reader
    {
        public List<SpaceObject> ReaderFile()
        {
            var spaceObjects = new List<SpaceObject>();

            DataContractJsonSerializer revealFile = new DataContractJsonSerializer(typeof(List<SpaceObject>));

            using (var file = new FileStream("Data.json", FileMode.OpenOrCreate))
            {
                spaceObjects = revealFile.ReadObject(file) as List<SpaceObject>;
            }
            return spaceObjects;
        }
    }
}
