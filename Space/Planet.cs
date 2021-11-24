using System.Runtime.Serialization;
using Task3.PersonalCharacteristics;

namespace Task3.Space
{
    [DataContract]
    public class Planet : SpaceObject
    {
        [DataMember]
        public string DistanceFromEarth { get; set; }
    }
}
