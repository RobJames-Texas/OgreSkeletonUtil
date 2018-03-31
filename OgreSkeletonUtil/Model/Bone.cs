using System;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Model
{
    [Serializable]
    public class Bone
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("position")]
        public Vector Position { get; set; }

        [XmlElement("rotation")]
        public Rotation Rotation { get; set; }
    }
}
