using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class showScore : MonoBehaviour {
	public Text scoreText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//set the score text to the score being held by the empty gameObject's ScoreKeeper script
		scoreText.text = ScoreKeeper.score.ToString();
	}
}
