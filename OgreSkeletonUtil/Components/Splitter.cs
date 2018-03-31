using OgreSkeletonUtil.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OgreSkeletonUtil.Components
{
    public static class Splitter
    {
        public static IEnumerable<Skeleton> Split(Skeleton combined)
        {
            List<Skeleton> seperated = new List<Skeleton>();

            foreach (Animation animation in combined.Animations)
            {
                Skeleton clone = new Skeleton()
                {
                    BoneHierarchy = combined.BoneHierarchy,
                    Bones = combined.Bones,
                    Animations = new Animation[] { animation }
                };

                seperated.Add(clone);
            }

            return seperated;
        }
    }
}
