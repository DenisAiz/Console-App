using System.Runtime.Serialization;
using Task3.PersonalCharacteristics;
using Task3.PrinterObject;

namespace Task3.Space
{
    [DataContract]
    public class Asteroid : SpaceObject
    {
        [DataMember]
        public string Weight { get; set; }
    }
}
