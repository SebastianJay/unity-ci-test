using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		int score = player.GetComponent<PlayerControl> ().numTokens * 100;
		this.gameObject.GetComponent<Text> ().text = string.Format ("Score: {0}", score);
	}
}
