namespace RJTX.Ogre.IO.Skeleton.Interfaces
{
    using RJTX.Ogre.Models.Skeleton;

    /// <summary>
    /// Allows an object to handle writing <see cref="Skeleton"/> objects.
    /// </summary>
    public interface ISkeletonWriter
    {
        /// <summary>
        /// Write the given <see cref="Skeleton"/> to the given file path.
        /// </summary>
        void Write(Skeleton skeleton, string path);
    }
}
