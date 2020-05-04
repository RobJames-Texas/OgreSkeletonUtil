using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Skeleton
{
    [Serializable]
    public class BoneParent
    {
        [XmlAttribute("bone")]
        public string Bone { get; set; }

        [XmlAttribute("parent")]
        public string Parent { get; set; }
    }
}
