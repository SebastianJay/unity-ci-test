using System;
using UnityEditor.SceneManagement;
using NUnit.Framework;

// This is run once per namespace, handling any setup and teardown common to all tests

[SetUpFixture]
public class TestConfig
{
	// this path should lead to where the editor should be open after testing is complete
	// TODO find a way to open the scene that was open when hitting the test button
	private static string returnScenePath = "Assets/Scenes/Main.unity";
	// this path should lead to an empty scene where the unit testing will occur
	private static string testScenePath = "Assets/Scenes/UnitTest.unity";

	[SetUp]
	public void Init() {
		// unless a new scene is opened the unit tests will run in the active scene, so objects there might interfere
		EditorSceneManager.OpenScene (testScenePath, OpenSceneMode.Single);
	}

	[TearDown]
	public void Dispose() {
		// go back to the original scene
		EditorSceneManager.OpenScene(returnScenePath, OpenSceneMode.Single);
	}
}
