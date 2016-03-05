using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class AsteroidCollisions : MonoBehaviour {
	//get the Lives Textbox
	public Text LivesText;
	//get the Score Textbox
	public Text ScoreText;
	// Use this for initialization
	public GameObject spaceship;
	private Renderer spaceshipRenderer;
	void Start () {
		spaceship = GameObject.Find("spaceship (1)");
		spaceshipRenderer = spaceship.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll){
		int currentScore = 0;
		float invincibleTime = 2.0f;
		float blinkTime = 0.2f;
		float blinkTimer;
		float timer;
		//destroy the asteroid if a bullet hits it and add 1 to the score variable in the ScoreKeeper class
		if (coll.name.StartsWith ("bullet")) {
			ScoreKeeper.score += 1;
			Destroy (this.gameObject);

		}
		if (coll.name.StartsWith ("spaceship")) {
			Destroy (this.gameObject);
		}


	}
}
