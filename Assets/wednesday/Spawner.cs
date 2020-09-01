using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] obstacles;
	public float delay = 1f;
	public float min_X = -5.5f;
	public float max_X = 5.5f;

	void Start () {
		InvokeRepeating("SpawnObstacle", 0, delay);
	}
	
	void SpawnObstacle () {
		int randomIndex = Random.Range(0, obstacles.Length);
		Vector3 position = new Vector3(
			Random.Range(min_X, max_X),
			transform.position.y,
			transform.position.z
		);
		GameObject obstacle = Instantiate(obstacles[randomIndex], position, transform.rotation);
		obstacle.transform.parent = transform;
	}
}
