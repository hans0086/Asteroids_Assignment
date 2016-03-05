using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class shipCollision : MonoBehaviour {
	public Text lives;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll){
		int currentLives;
		//if colliding with an asteroid
		if (coll.name.StartsWith ("asteroid")) {
			//get the current number of lives
			currentLives = int.Parse (lives.text);
			//decrement by 1
			currentLives -= 1;
			//check to see if game over
			if (currentLives <= 0) {
				Application.LoadLevel (0);
			}
			//output the number of lives back to the text box
			lives.text = currentLives.ToString ();
		}

	}

}
