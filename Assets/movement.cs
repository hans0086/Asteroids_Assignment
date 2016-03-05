using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	private float xPos;
	private float yPos;
	private Vector3 bottomLeft;
	private Vector3 topRight;
	public float movementSpeed = 10.0f;
	// Use this for initialization
	void Start () {
		//get the asteroids x position
		xPos = transform.position.x;
		//get the asteroids y position
		yPos = transform.position.y;
		//get the world coordinates for the viewport boundaries
		bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, transform.position.z));
		topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.localPosition;
		//increase the x and y positions by the desired movespeed
		position.x += movementSpeed * Time.deltaTime;
		position.y += movementSpeed * Time.deltaTime;
		//if the asteroid is to the right of the screen, reverse the x positions
		if (position.x > topRight.x) {
			position.x = -position.x;

		}
		//if the asteroid is above the screen reverse the y position
		if (position.y > topRight.y) {
			position.y = -position.y;

		}
		//set the current asteroid position
		transform.localPosition = position;
	}
}
