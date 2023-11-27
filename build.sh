#!/bin/bash

# chmod +x build.sh

# Path to the C# file
FILE_PATH="CS2_ExecAfter/CS2_ExecAfter.cs"

# Extract the version number
VERSION=$(grep 'public override string ModuleVersion' $FILE_PATH | awk -F'"' '{print $2}')

# Print the version
echo "Version: $VERSION"

dotnet publish -c Release /p:Version=$VERSION
