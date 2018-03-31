using System;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Model
{
    [Serializable]
    public class Vector
    {
        [XmlAttribute("x")]
        public decimal X { get; set; }

        [XmlAttribute("y")]
        public decimal Y { get; set; }

        [XmlAttribute("z")]
        public decimal Z { get; set; }
    }
}
