namespace RJTX.Ogre.Skeleton.IO.Components
{
    using RJTX.Ogre.Skeleton.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Class used to split <see cref="Animation"/> objects on a single <see cref="Skeleton"/> object.
    /// </summary>
    public static class Splitter
    {
        /// <summary>
        /// Method to take a <see cref="Skeleton"/> object with multiple <see cref="Animation"/> objects and create new <see cref="Skeleton"/> objects with only one <see cref="Animation"/> object.
        /// </summary>
        /// <param name="combined">The <see cref="Skeleton"/> object to split animations from.</param>
        /// <returns><see cref="Skeleton"/> object with only one animation.</returns>
        public static IEnumerable<Skeleton> Split(Skeleton combined)
        {
            List<Animation> animations = new List<Animation>();
            animations.Add(Bind); // Make sure there is always a bind animation.
            animations.AddRange(combined.Animations);

            foreach (Animation animation in animations)
            {
                Skeleton clone = new Skeleton()
                {
                    BoneHierarchy = combined.BoneHierarchy,
                    Bones = combined.Bones,
                    Animations = new Animation[] { animation }
                };

                yield return clone;
            }
        }

        private static Animation Bind = new Animation() { Name = "Bind", Length = 0, Tracks = new Track[0] };
    }
}
