using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {
	public GameObject cube;
	bool cubeHasSpawned = false;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (Time.time > 3 && cubeHasSpawned == false) {
			Instantiate (cube, new Vector3 (0, 0, 0), Quaternion.identity);
			cubeHasSpawned = true;
		}
	}
}
