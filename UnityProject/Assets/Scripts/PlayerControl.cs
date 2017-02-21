using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This line enables the testing framework to call internal methods
[assembly:System.Runtime.CompilerServices.InternalsVisibleTo("Assembly-CSharp-Editor")]

public class PlayerControl : MonoBehaviour {

	public delegate void GotTokenHandler(GameObject sender, GotTokenEvent e);
	public event GotTokenHandler GotToken;

	public float moveForce;
	public float jumpForce;

	private bool grounded;
	private int numTokens;

	// Use this for initialization
	void Start () {
		numTokens = 0;
		grounded = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float xval = Input.GetAxis ("Horizontal");
		float yval = Input.GetAxis ("Vertical");
		if (grounded && yval > 0) {
			this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce));
		}
		if (xval != 0) {
			this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (moveForce * Mathf.Sign(xval), 0f));
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Target") {
			incToken ();
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			grounded = false;
		}
	}

	internal void incToken() {
		numTokens += 1;
		if (GotToken != null) {
			GotToken (this.gameObject, new GotTokenEvent { currentNumberTokens = this.numTokens } );
		}
	}
}
