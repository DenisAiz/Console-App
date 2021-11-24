using System.Runtime.Serialization;
using Task3.PersonalCharacteristics;
using Task3.PrinterObject;

namespace Task3.Space
{
    [DataContract]
    [KnownType(typeof(Planet))]
    [KnownType(typeof(Star))]
    [KnownType(typeof(Asteroid))]
    [KnownType(typeof(BlackHole))]
    public class SpaceObject
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
