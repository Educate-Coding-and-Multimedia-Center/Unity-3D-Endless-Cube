using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score;
	private Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score ++;
		scoreText.text = score.ToString();
	}
}
