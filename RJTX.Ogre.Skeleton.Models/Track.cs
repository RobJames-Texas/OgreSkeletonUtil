using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Skeleton.Models
{
    [Serializable]
    public class Track
    {
        [XmlAttribute("bone")]
        public string Bone { get; set; }

        [XmlArray("keyframes")]
        [XmlArrayItem("keyframe")]
        public KeyFrame[] KeyFrames { get; set; }
    }
}
