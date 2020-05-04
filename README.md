# OgreSkeletonUtil

Splits animations in a single Ogre3d Skeleton xml file into individual xml files for each animation.

I was adding a new 3d model to the Torchlight2 game, that uses the Ogre3d engine, using Blender and the OGRECave/blender2ogre plugin.  It exports all the animations into one big skeleton file but Torchlight2 needed the animations in separate files. I wrote this utility to do the conversion for me.

v1.1.1

Bugfixes: Fixed serialization. Ogre command line tools uses floats for vector properties. Now we can properly serialize scientific notation used in vectors.  Updated builds to no longer include folders.

v1.1.0

Bugfixes: Fixed argument out of range exception when starting application with no arguments. Fixed creating animations folder if it does not exist.  Adding checking for invalid characters in the file name used for the individual animations.

v1.0.0

Releases: <https://github.com/Vkoslak/OgreSkeletonUtil/releases>

Written in dot net core 3.0 with Visual Studio 2019.

## Usage

* Windows 10 and up 32/64bit **"OgreSkeletonUtil.exe"**
* OSX 10.10 x64 and up **"OgreSkeletonUtil"**

Takes one argument, the skeleton xml file you want to split.

I would just drag your skeleton xml file onto the exe.

The animations will be dumped into a folder "animations" where the source skeleton xml file is located.

Scaling is ignored.

### Release notes

* v1.0.0 -- Initial release.


# OgreXMLConvertToDedicatedVerticies
Tool to take XML files from Ogre 3d mesh files and convert them from using shared vertices to dedicated.

I added a new 3d model to the Torchlight2 game in a mod. Torchlight 2 uses the Ogre3d engine. I've been working in Blender and using the OGRECave/blender2ogre plugin.  It only exports the meshes using shared verticies. In order for the player model to work correctly in Torchlight2, I need the meshes to not use shared verticies. I wrote this utility to do the conversion for me.

v1.0.0

Releases: <https://github.com/Vkoslak/OgreSkeletonUtil/releases>

Written in dot net core 3.0 with Visual Studio 2019. The libraries use dot net standard 2.0. I did that so I can make nuget packages that are compatible with dot net framework.

## Usage

* Windows 10 and up 32/64bit **"OgreXMLConvertToDedicatedVerticies.exe"**
* OSX 10.10 x64 and up **"OgreXMLConvertToDedicatedVerticies"**

Takes one argument, the mesh xml file you want convert.

I would just drag your mesh xml file onto the exe, or make a shortcut.

Note. The application will make a backup of your file before overwriting it with the dedicated verticies version. If the backup already exists, you are given the option to exit, skip the backup, or overwrite the backup.

Current limitation is that it only works if the file has one submesh in it.

### Release notes

* v1.0.0 -- Initial release.

### Author

* Rob James