using System;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Model
{
    [Serializable]
    public class KeyFrame
    {
        [XmlAttribute("time")]
        public decimal Time { get; set; }

        [XmlElement("translate")]
        public Vector Translate { get; set; }

        [XmlElement("rotate")]
        public Rotation Rotate { get; set; }

        [XmlElement("scale")]
        public Vector Scale { get; set; }
    }
}
