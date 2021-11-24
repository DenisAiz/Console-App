using System.Runtime.Serialization;
using Task3.PersonalCharacteristics;
using Task3.PrinterObject;

namespace Task3.Space
{
    [DataContract]
    public class BlackHole : SpaceObject
    {
        [DataMember]
        public string Diameter { get; set; }
    }
}
