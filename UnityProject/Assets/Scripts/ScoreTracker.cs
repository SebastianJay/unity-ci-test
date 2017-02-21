using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[assembly:System.Runtime.CompilerServices.InternalsVisibleTo("Assembly-CSharp-Editor")]

public class ScoreTracker : MonoBehaviour {

	public int scoreMultiplier;
	private GameObject player;

	public int score { get; internal set; }

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		player.GetComponent<PlayerControl> ().GotToken += Notify;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<Text> ().text = string.Format ("Score: {0}", score);
	}

	void Notify(GameObject sender, GotTokenEvent e) {
		score = e.currentNumberTokens * scoreMultiplier;
	}
}
