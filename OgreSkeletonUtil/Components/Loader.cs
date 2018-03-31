using OgreSkeletonUtil.Model;
using System;
using System.IO;
using System.Xml.Serialization;

namespace OgreSkeletonUtil.Components
{
    public class Loader
    {
        private XmlSerializer _serializer;

        public Loader()
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "skeleton";
            xRoot.IsNullable = true;

            _serializer = new XmlSerializer(typeof(Skeleton), xRoot);

            // If the XML document has been altered with unknown   
            // nodes or attributes, handles them with the   
            // UnknownNode and UnknownAttribute events.  
            _serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            _serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute);
        }

        public Skeleton Load(string filename)
        {
            Skeleton skeleton = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                skeleton = (Skeleton)_serializer.Deserialize(fs);
            }
            return skeleton;
        }

        protected void serializer_UnknownNode
        (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        protected void serializer_UnknownAttribute
        (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}
