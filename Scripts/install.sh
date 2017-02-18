#! /bin/sh

# Download Unity3D installer into the container
#  The below link will need to change depending on the version, this one is for 5.5.1
#  Refer to https://unity3d.com/get-unity/download/archive and find the link pointed to by Mac "Unity Editor"
echo 'Downloading Unity 5.5.1 pkg:'
curl -o Unity.pkg http://netstorage.unity3d.com/unity/88d00a7498cd/MacEditorInstaller/Unity-5.5.1f1.pkg

# Run installer
echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /
