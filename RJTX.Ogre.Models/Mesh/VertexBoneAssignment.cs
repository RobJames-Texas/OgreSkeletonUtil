using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Mesh
{
    public class VertexBoneAssignment
    {
        [XmlAttribute("boneindex")]
        public long BoneIndex { get; set; }

        [XmlAttribute("vertexindex")]
        public long VertexIndex { get; set; }

        [XmlAttribute("weight")]
        public decimal Weight { get; set; }
    }
}
