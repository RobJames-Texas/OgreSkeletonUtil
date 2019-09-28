namespace RJTX.Ogre.Skeleton.IO.Components
{
    using RJTX.Ogre.Skeleton.IO.Interfaces;
    using RJTX.Ogre.Skeleton.Models;
    using System;
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// An implementation of <see cref="ISkeletonLoader"/> for loadking <see cref="Skeleton"/> objects from Ogre XML.
    /// </summary>
    public class Loader : ISkeletonLoader
    {
        private XmlSerializer _serializer;

        /// <summary>
        /// Initializes a new instance of <see cref="Loader"/>.
        /// </summary>
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

        /// <summary>
        /// Load a <see cref="Skeleton"/> from the given file path.
        /// </summary>
        /// <param name="filename">The path to the xml file containing the skeleton xml.</param>
        public Skeleton Load(string filename)
        {
            Skeleton skeleton = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                skeleton = (Skeleton)_serializer.Deserialize(fs);
            }
            return skeleton;
        }

        private void serializer_UnknownNode
        (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute
        (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}
