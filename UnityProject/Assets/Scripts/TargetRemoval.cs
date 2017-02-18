using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRemoval : MonoBehaviour {

	public float lifeTime;

	private float lifeTimer;

	// Use this for initialization
	void Start () {
		lifeTimer = 0f;	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTimer += Time.deltaTime;
		if (lifeTimer >= lifeTime) {
			Destroy (this.gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Destroy (this.gameObject);
		}
	}
}
