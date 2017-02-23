#! /bin/sh

winname="${UNITYCI_PROJECT_NAME}_win.tar.gz"
osxname="${UNITYCI_PROJECT_NAME}_osx.tar.gz"

# tar and zip the build folders
tar -czvf $winname "$(pwd)/Build/windows"
tar -czvf $osxname "$(pwd)/Build/osx"

# upload the tarballs to the server for storage
scp -i $UPLOAD_KEYPATH -o stricthostkeychecking=no $winname $UPLOAD_USER@$UPLOAD_HOST:$UPLOAD_PATH
scp -i $UPLOAD_KEYPATH -o stricthostkeychecking=no $osxname $UPLOAD_USER@$UPLOAD_HOST:$UPLOAD_PATH