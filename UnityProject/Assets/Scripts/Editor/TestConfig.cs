using System;
using UnityEditor.SceneManagement;
using NUnit.Framework;

// This is run once per namespace, handling any setup and teardown common to all tests

[SetUpFixture]
public class TestConfig
{
	private string returnScenePath;

	[SetUp]
	public void Init() {
		// grab the path of the scene which is currently open
		if (EditorSceneManager.loadedSceneCount > 0) {
			this.returnScenePath = EditorSceneManager.GetSceneAt(0).path;
		}

		// create a new blank scene so objects in the active scene do not interfere with tests
		EditorSceneManager.NewScene (NewSceneSetup.EmptyScene, NewSceneMode.Single);
	}

	[TearDown]
	public void Dispose() {
		// go back to the original scene
		if (returnScenePath.Length > 0) {
			EditorSceneManager.OpenScene(returnScenePath, OpenSceneMode.Single);
		}
	}
}
