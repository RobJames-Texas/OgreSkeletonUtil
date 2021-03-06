﻿using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Skeleton
{
    [Serializable]
    public class Vector
    {
        [XmlAttribute("x")]
        public float X { get; set; }

        [XmlAttribute("y")]
        public float Y { get; set; }

        [XmlAttribute("z")]
        public float Z { get; set; }
    }
}
