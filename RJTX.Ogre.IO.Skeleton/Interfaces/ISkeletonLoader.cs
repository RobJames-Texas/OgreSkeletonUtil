namespace RJTX.Ogre.IO.Skeleton.Interfaces
{
    using RJTX.Ogre.Models.Skeleton;

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
