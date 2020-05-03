namespace RJTX.Ogre.IO.Skeleton.Components
{
    using RJTX.Ogre.IO.Skeleton.Interfaces;
    using RJTX.Ogre.Models.Skeleton;
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// An implementation of <see cref="ISkeletonWriter"/> for writing <see cref="Skeleton"/> objects to Ogre XML.
    /// </summary>
    public class Writer : ISkeletonWriter
    {
        private const string extension = "SKELETON";

        private XmlSerializer _serializer;

        /// <summary>
        /// Initializes a new instance of <see cref="Writer"/>.
        /// </summary>
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

        /// <summary>
        /// Write the given <see cref="Skeleton"/> to the given file path.
        /// </summary>
        public void Write(Skeleton skeleton, string path)
        {
            string name = skeleton.Animations.Single().Name.ToUpper();

            if (name.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
            {
                throw new ArgumentException($"Invalid characters in animation name. {name}\nThe name must be able to be used in the file name. Please correct the name and try again.");
            }

            string filename = $"{path}\\{name}.{extension}.xml";

            (new FileInfo(filename)).Directory.Create();

            Console.WriteLine($"Writing {filename}");
            using (TextWriter writer = new StreamWriter(filename))
            {
                _serializer.Serialize(writer, skeleton);
                writer.Close();
            }
        }
    }
}
