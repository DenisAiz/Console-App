using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Task3.Space;

namespace Task3
{
    class Writer
    {
        public void AddContent(List<SpaceObject> spaceObjects)
        {
            DataContractJsonSerializer spaсeObject = new DataContractJsonSerializer(typeof(List<SpaceObject>));

            using (var fs = new FileStream("Data.json", FileMode.Create))
            {
                spaсeObject.WriteObject(fs, spaceObjects);
            }
        }
    }
}




