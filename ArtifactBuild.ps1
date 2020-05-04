New-Item -Path .\Artifacts -ItemType Directory -Force
New-Item -Path .\Artifacts\RJTX-Ogre-Tools-x64 -ItemType Directory -Force
New-Item -Path .\Artifacts\RJTX-Ogre-Tools-x86 -ItemType Directory -Force
New-Item -Path .\Artifacts\RJTX-Ogre-Tools-osx -ItemType Directory -Force

Copy-Item -Path .\OgreSkeletonUtil\bin\Release\netcoreapp3.1\win10-x64\publish\*.exe -Destination .\Artifacts\RJTX-Ogre-Tools-x64
Copy-Item -Path .\OgreXMLConvertToDedicatedVerticies\bin\Release\netcoreapp3.1\win10-x64\publish\*.exe -Destination .\Artifacts\RJTX-Ogre-Tools-x64

Copy-Item -Path .\OgreSkeletonUtil\bin\Release\netcoreapp3.1\win10-x86\publish\*.exe -Destination .\Artifacts\RJTX-Ogre-Tools-x86
Copy-Item -Path .\OgreXMLConvertToDedicatedVerticies\bin\Release\netcoreapp3.1\win10-x86\publish\*.exe -Destination .\Artifacts\RJTX-Ogre-Tools-x86

Copy-Item -Path .\OgreSkeletonUtil\bin\Release\netcoreapp3.1\osx.10.10-x64\publish\OgreSkeletonUtil -Destination .\Artifacts\RJTX-Ogre-Tools-osx
Copy-Item -Path .\OgreXMLConvertToDedicatedVerticies\bin\Release\netcoreapp3.1\osx.10.10-x64\publish\OgreXMLConvertToDedicatedVerticies -Destination .\Artifacts\RJTX-Ogre-Tools-osx

Compress-7Zip ".\Artifacts\RJTX-Ogre-Tools-x64\" -ArchiveFileName ".\Artifacts\RJTX-Ogre-Tools-x64.zip" -Format Zip
Compress-7Zip ".\Artifacts\RJTX-Ogre-Tools-x86\" -ArchiveFileName ".\Artifacts\RJTX-Ogre-Tools-x86.zip" -Format Zip
Compress-7Zip ".\Artifacts\RJTX-Ogre-Tools-osx\" -ArchiveFileName ".\Artifacts\RJTX-Ogre-Tools-osx.zip" -Format Zip

