using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class bulletCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll){
		//if colliding with an asteroid, destroy the bullet
		if (coll.name.StartsWith ("asteroid")) {
			Destroy (this.gameObject);
		}

	}
}
