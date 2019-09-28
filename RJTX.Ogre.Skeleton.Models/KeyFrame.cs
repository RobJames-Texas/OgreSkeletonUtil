using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Skeleton.Models
{
    [Serializable]
    public class KeyFrame
    {
        private decimal _time = 0;

        [XmlAttribute("time")]
        public string Time
        {
            get
            {
                return _time.ToString("F5");
            }
            set
            {
                decimal amount = 0;
                if (Decimal.TryParse(value, out amount))
                {
                    _time = amount;
                }
            }
        }

        [XmlElement("translate")]
        public Vector Translate { get; set; }

        [XmlElement("rotate")]
        public Rotation Rotate { get; set; }

        [XmlElement("scale")]
        public Vector Scale { get; set; }
    }
}
