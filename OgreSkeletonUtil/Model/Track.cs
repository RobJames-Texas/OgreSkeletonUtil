using System;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Model
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
