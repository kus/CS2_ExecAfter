#!/bin/bash

# chmod +x release.sh

# Path to the C# file
FILE_PATH="CS2_ExecAfter/CS2_ExecAfter.cs"

# Extract the version number
VERSION=$(grep 'public override string ModuleVersion' $FILE_PATH | awk -F'"' '{print $2}')

# Print the version
echo "Version: $VERSION"

# Completely remove our previously generated "dist" folder
rm -rf dist/

# Create our base "dist" folder
mkdir -p dist

# Create our folder for storing the files and directories we want zipped
mkdir -p dist/addons/counterstrikesharp/plugins/CS2_ExecAfter

# Add files
cp -r CS2_ExecAfter/bin/Release/net7.0/publish/CS2_ExecAfter.dll dist/addons/counterstrikesharp/plugins/CS2_ExecAfter/CS2_ExecAfter.dll

# Create our zip file from the folder "dist" and name it "CS2_ExecAfter-version.zip"
(cd dist && zip -r ../CS2_ExecAfter-$VERSION.zip .)

# Show some info about file
ls -l CS2_ExecAfter-$VERSION.zip

# Completely remove our previously generated "dist" folder
rm -rf dist/

# v1.0.0
versionLabel=v$VERSION
 
# create tag for master
git tag $versionLabel
