using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour {

	public GameObject targetPrefab;
	public float spawnTime;
	public float spawnY;
	public float spawnXMin;
	public float spawnXMax;

	private float spawnTimer;

	// Use this for initialization
	void Start () {
		spawnTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if (spawnTimer >= spawnTime) {
			Vector3 newPos = new Vector3(Random.Range (spawnXMin, spawnXMax) ,spawnY, 0f);
			Instantiate (targetPrefab, newPos, Quaternion.identity);
			spawnTimer = 0f;
		}
	}
}
