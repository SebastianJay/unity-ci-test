#! /bin/sh

winname="${UNITYCI_PROJECT_NAME}_win.tar.gz"
osxname="${UNITYCI_PROJECT_NAME}_osx.tar.gz"

# tar and zip the build folders
tar -C "$(pwd)/Build" -czvf $winname "windows"
tar -C "$(pwd)/Build" -czvf $osxname "osx"

# upload the tarballs to the server for storage
scp -i "${UPLOAD_KEYPATH}" \
	-o stricthostkeychecking=no \
	-o loglevel=quiet \
	$winname "${UPLOAD_USER}@${UPLOAD_HOST}:${UPLOAD_PATH}"
scp -i "${UPLOAD_KEYPATH}" \
	-o stricthostkeychecking=no \
	-o loglevel=quiet \
	$osxname "${UPLOAD_USER}@${UPLOAD_HOST}:${UPLOAD_PATH}"