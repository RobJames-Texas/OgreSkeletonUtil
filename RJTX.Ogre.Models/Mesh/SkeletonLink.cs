using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Mesh
{
    public class SkeletonLink
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
