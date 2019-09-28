namespace RJTX.Ogre.Skeleton.IO.Interfaces
{
    using RJTX.Ogre.Skeleton.Models;

    /// <summary>
    /// Allows object to handle loading <see cref="Skeleton"/> objects.
    /// </summary>
    public interface ISkeletonLoader
    {
        /// <summary>
        /// Load a <see cref="Skeleton"/> from the given file path.
        /// </summary>
        Skeleton Load(string filename);
    }
}
