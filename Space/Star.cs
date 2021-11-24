using System.Runtime.Serialization;
using Task3.PersonalCharacteristics;
using Task3.PrinterObject;

namespace Task3.Space
{
    [DataContract]
    public class Star : SpaceObject
    {
        [DataMember]
        public string NumberOfYears { get; set; }
    }
}
