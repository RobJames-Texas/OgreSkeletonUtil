using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Mesh
{
    [Serializable]
    public class TexCoord
    {
        [XmlAttribute("u")]
        public decimal U { get; set; }

        [XmlAttribute("v")]
        public decimal V { get; set; }
    }
}
