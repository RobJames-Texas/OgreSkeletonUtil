using OgreSkeletonUtil.Interfaces;
using OgreSkeletonUtil.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Components
{
    public class Writer : ISkeletonWriter
    {
        private const string extension = "SKELETON";

        private XmlSerializer _serializer;

        public Writer()
        {
            XmlAttributes attrs = new XmlAttributes();

            // Ignore scale.
            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            XmlAttributes attribs = new XmlAttributes();
            attribs.XmlIgnore = true;
            attribs.XmlElements.Add(new XmlElementAttribute("scale"));
            overrides.Add(typeof(KeyFrame), "Scale", attribs);

            _serializer = new XmlSerializer(typeof(Skeleton), overrides);
        }

        public void Write(Skeleton skeleton, string path)
        {
            string name = skeleton.Animations.Single().Name.ToUpper();

            string filename = $"{path}\\{name}.{extension}.xml";

            Console.WriteLine($"Writing {filename}");
            using (TextWriter writer = new StreamWriter(filename))
            {
                _serializer.Serialize(writer, skeleton);
                writer.Close();
            }
        }
    }
}
