using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Skeleton.Models
{
    [Serializable]
    public class Rotation
    {
        [XmlAttribute("angle")]
        public decimal Angle { get; set; }

        [XmlElement("axis")]
        public Vector Axis { get; set; }
    }
}
