using System;
using System.Linq;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Mesh
{
    [Serializable]
    public class Geometry
    {
        [XmlAttribute("vertexcount")]
        public long VertexCount 
        {
            get
            {
                return VertexBuffer.Vertices.Count();
            }
            set { }
        }

        [XmlElement("vertexbuffer")]
        public VertexBuffer VertexBuffer { get; set; }
    }
}
