using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using NUnit.Framework;

public class PlayerControlTest {

	[Test]
	public void ScoreUpdatesWithToken() {
		var player = new GameObject();
		TestHelper.AddMonoBehaviourAndInit<PlayerControl> (player);
		player.tag = "Player";

		var tracker = new GameObject ();
		TestHelper.AddMonoBehaviourAndInit<ScoreTracker>(tracker);
		tracker.GetComponent<ScoreTracker> ().scoreMultiplier = 100;
		//tracker.GetComponent<ScoreTracker> ().Awake ();

		player.GetComponent<PlayerControl> ().incToken ();

		Assert.AreEqual (1 * 100, tracker.GetComponent<ScoreTracker> ().score);
	}
}
