using UnityEngine;
using System.Collections;

public class BulletPath : MonoBehaviour {
	//public Rigidbody2D bullet;
	public GameObject spaceship;
	private Vector2 direction;
	public float bulletSpeed = 10.0f;
	public float bulletLifeTime = 2.0f;
	private float bulletTimer;
	private Vector3 bottomLeft;
	private Vector3 topRight;
	private Vector2 currentPosition;
	// Use this for initialization
	void Start () {
		
		//get the worldview boundary coordinates for the viewport boundaries
		bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, transform.position.z));
		topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, transform.position.z));
		//set the bulletTimer to the 2 second lifeTime
		bulletTimer = bulletLifeTime;
		//get the spaceship object
		spaceship = GameObject.Find ("spaceship (1)");
		//get the current forward direction of the spaceship
		direction = spaceship.transform.up;
		//get the current x and y positions of the space ship
		currentPosition.x = spaceship.transform.position.x;
		currentPosition.y = spaceship.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 position = transform.localPosition;
		//move the bullet in the direction the ship is aiming at the desired speed
		currentPosition += direction * bulletSpeed * Time.deltaTime;
		//kill the bullet after 2 seconds
		bulletTimer -= Time.deltaTime;
		if (bulletTimer <= 0.0f) {
			Destroy (this.gameObject);
		}
		//take the opposite x coordinate if the bullet is going to the right or left of the screen
		if (currentPosition.x > topRight.x || currentPosition.x < bottomLeft.x) {
			currentPosition.x = -currentPosition.x;

		}
		//take the opposite y cooridnate if the bullet is going above or below the screen
		if (currentPosition.y > topRight.y || currentPosition.y < bottomLeft.y) {
			currentPosition.y = -(currentPosition.y - 2);

		}
		//set the position of the bullet
		transform.localPosition = currentPosition;

	}
}
