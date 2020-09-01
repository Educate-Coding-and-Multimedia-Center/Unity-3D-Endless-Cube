using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {

	public float speed = 20f;
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3(0, 0, -1);
		transform.Translate(direction * Time.deltaTime * speed);

		int score = FindObjectOfType<Score>().score;
		if ((score % 1000) == 0)
		{
			speed += 10f;
		}
	}

	void OnCollisionEnter(Collision target) {
		if (target.gameObject.tag == "Player")
		{
			Time.timeScale = 0f;
			SceneManager.LoadScene("menu");
		}
	}

	void OnTriggerEnter(Collider target) {
		if (target.gameObject.tag == "Destroyer")
		{
			Destroy(gameObject);
		}
	}
}
