using UnityEngine;
using System.Collections;


public class spawnAsteroids : MonoBehaviour {
	public float setTime = 2.0f;
	public GameObject asteroidPreFab;
	private float spawnTimer;
	private Camera cam = Camera.main;
	private int randomWall;
	private float yCoord;
	private float xCoord;
	private int i = 0;
	private Vector3 spawnedAsteroidPosition;
	// Use this for initialization
	void Start () {
		spawnTimer = setTime;
	}
	
	// Update is called once per frame
	void Update () {
		
		spawnTimer -= Time.deltaTime;
		if (spawnTimer <= 0.0f) {
			spawnTimer = setTime;
				Spawn ();
				i++;
		}

	}
	void Spawn(){
		//determines which side the asteroid will spawn from
		randomWall = Random.Range (0, 2);
		//if 1, asteroid will spawn on left wall
		if (randomWall == 1) {
			xCoord = Random.Range (0.0f, 1.0f);
			yCoord = 0;
		} else {
			//else asteroid will spawn on bottom wall
			yCoord = Random.Range (0.0f, 1.0f);
			xCoord = 0;
		}
		//get the world position of where the asteroid will spawn
		spawnedAsteroidPosition = Camera.main.ViewportToWorldPoint (new Vector3 (xCoord, yCoord, 0));
		//spawn the asteroid
		Instantiate (asteroidPreFab, new Vector3 (spawnedAsteroidPosition.x, spawnedAsteroidPosition.y, 0), Quaternion.identity);
	}
	
}
