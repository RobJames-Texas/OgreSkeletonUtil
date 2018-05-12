# OgreSkeletonUtil

Splits animations in a single Ogre3d Skeleton xml file into individual xml files for each animation.

I was adding a new 3d model to the Torchlight2 game, that uses the Ogre3d engine, using Blender and the OGRECave/blender2ogre plugin.  It exports all the animations into one big skeleton file but Torchlight2 needed the animations in separate files. I wrote this utility to do the conversion for me.

v1.1.0

Bugfixes: Fixed argument out of range exception when starting application with no arguments. Fixed creating animations folder if it does not exist.  Adding checking for invalid characters in the file name used for the individual animations.

v1.0.0

Releases: <https://github.com/Vkoslak/OgreSkeletonUtil/releases>

Written in dot net core 2.0 with Visual Studio 2017.

## Usage

* Windows 7 and up 32/64bit **"OgreSkeletonUtil.exe"**
* OSX 10.10 x64 and up **"OgreSkeletonUtil"**

Takes one argument, the skeleton xml file you want to split.

I would just drag your skeleton xml file onto the exe.

The animations will be dumped into a folder "animations" where the source skeleton xml file is located.

Scaling is ignored.

### Release notes

* v1.0.0 -- Initial release.

### Author

* Rob James