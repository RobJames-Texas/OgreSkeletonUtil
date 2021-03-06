﻿using RJTX.Ogre.IO.Skeleton.Components;
using RJTX.Ogre.Models.Skeleton;
using System;
using System.IO;
using System.Linq;

namespace OgreSkeletonUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = args.FirstOrDefault();

            if (!File.Exists(filename))
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

            Console.WriteLine($"Skeleton count: {seperated.Count()}");
            Console.WriteLine("Press any key to write a separate skeleton xml for each animation.");
            Console.ReadKey();

            Writer writer = new Writer();
            try
            {
                foreach (Skeleton single in seperated)
                {
                    writer.Write(single, $"{path}\\animations");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ERROR!!!\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
                return;
            } 

            Console.WriteLine("Finished writing skeleton xml. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
