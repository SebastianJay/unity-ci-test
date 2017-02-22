# unity-ci-test
An example of continuous integration for Unity projects.

This project uses the [excellent tutorial by Jonathan Porta](https://jonathan.porta.codes/2015/04/17/automatically-build-your-unity3d-project-in-the-cloud-using-travisci-for-free/) as well as the [Unity manual on the test runner](https://docs.unity3d.com/Manual/testing-editortestsrunner.html) to run unit tests on TravisCI and proceed to build the project. From there, we have some extra scripts to upload the builds to a server. A cloud alternative for this is Travis's S3 addon that integrates with AWS.

Parts of this project can also be accomplished through Unity Cloud Build, but the Travis approach offers tighter control if a developer wants to fork and customize.
