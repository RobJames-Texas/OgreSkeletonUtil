using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Skeleton
{
    [Serializable]
    [XmlRootAttribute("skeleton", IsNullable = true)]
    public class Skeleton
    {
        [XmlArray("bones")]
        [XmlArrayItem("bone")]
        public Bone[] Bones { get; set; }

        [XmlArray("bonehierarchy")]
        [XmlArrayItem("boneparent")]
        public BoneParent[] BoneHierarchy { get; set; }

        [XmlArray("animations")]
        [XmlArrayItem("animation")]
        public Animation[] Animations { get; set; } 
    }
}
