using OgreSkeletonUtil.Components;
using OgreSkeletonUtil.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OgreSkeletonUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = args.FirstOrDefault();

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("\n\nFile does not exist.\n\nThe only command line argument must be the skeleton xml to convert\n\n Press any key to exit.\n\n");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\n\nFile detected.\n\nBegin parsing skeleton xml.\n\nCtrl-C to exit.\n\n");

            string path = Path.GetDirectoryName(filename);

            Loader loader = new Loader();
            Skeleton skeleton = loader.Load(filename);

            Skeleton[] seperated = Splitter.Split(skeleton).ToArray();

            Console.WriteLine($"Skelton count: {seperated.Count()}");
            Console.WriteLine("Press any key to write a seperate skeleton xml for each animation.");
            Console.ReadKey();

            Writer writer = new Writer();
            foreach (Skeleton single in seperated)
            {
                writer.Write(single, $"{path}\\animations");
            }

            Console.WriteLine("Finished writing skeleton xml. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
