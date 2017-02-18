using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public int numTokens;
	public float moveForce;
	public float jumpForce;

	private bool grounded;

	// Use this for initialization
	void Start () {
		numTokens = 0;
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
			numTokens += 1;
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
}
