using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
	}
	
}
