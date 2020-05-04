namespace RJTX.Ogre.IO.Mesh.Interfaces
{
    using RJTX.Ogre.Models.Mesh;

    /// <summary>
    /// Allows an object to handle loading <see cref="Mesh"/> objects.
    /// </summary>
    public interface IMeshLoader
    {
        /// <summary>
        /// Load a <see cref="Mesh"/> from the given file path.
        /// </summary>
        Mesh Load(string filename);
    }
}
