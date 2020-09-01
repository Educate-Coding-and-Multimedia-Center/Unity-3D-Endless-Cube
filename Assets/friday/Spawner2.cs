using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour {

	public GameObject[] obstacles;
	public float timeToSpawn = 2f;
	public float min_X = -5.5f;
	public float max_X = 5.5f;
	
	void Start () {
		InvokeRepeating("SpawnObstacle", 0, timeToSpawn);
	}

	void SpawnObstacle()
	{
		int random = Random.Range(0, obstacles.Length);
		Vector3 randomPos = new Vector3(
			Random.Range(min_X, max_X),
			transform.position.y,
			transform.position.z
		);
		Instantiate(
			obstacles[random],
			randomPos,
			transform.rotation
		);
	}
}
