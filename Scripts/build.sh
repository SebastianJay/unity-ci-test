# !/bin/sh

# Rename to your project name
project="UnityProject"

echo "Attempting build of $project for Windows"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
	-batchmode \
	-nographics \
	-silent-crashes \
	-logFile $(pwd)/unity.log \
	-projectPath $(pwd) \
	-buildWindowsPlayer "$(pwd)/Build/windows/$project.exe" \
	-quit

echo "Attempting build of $project for OSX"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
	-batchmode \
	-nographics \
	-silent-crashes \
	-logFile $(pwd)/unity.log \
	-projectPath $(pwd) \
	-buildOSXUniversalPlayer "$(pwd)/Build/osx/$project.app" \
	-quit

echo "Build logs"
cat $(pwd)/unity.log
