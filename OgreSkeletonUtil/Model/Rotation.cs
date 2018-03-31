using System;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Model
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
