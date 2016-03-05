using UnityEngine;
using System.Collections;

public class shipMovement : MonoBehaviour {
	public float rotateSpeed = 30f;
	public float movementSpeed = 0.5f;
	public float acceleration = 500.0f;
	private float maxSpeed = 10000.0f;
	private Vector3 bottomLeft;
	private Vector3 topRight;
	private Vector2 direction;
	// Use this for initialization
	void Start () {
		//get the worldview coordinates for the viewpoint coordinates
		bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, transform.position.z));
		topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = transform.position;
		if (Input.GetKey (KeyCode.UpArrow)) {
			//moves the ship in the direction the front of the ship is aiming at, and applies an acceleration depending
			//on how long the button is held
			GetComponent<Rigidbody2D> ().AddForce (transform.up * Time.deltaTime * acceleration);
		}
		if (Input.GetKey (KeyCode.RightArrow)){
			//rotates the ship to the right at the desired speed
			transform.Rotate (0,0, -rotateSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)){
			//rotates the ship to the left at the desired speed
			transform.Rotate (0,0, rotateSpeed * Time.deltaTime);
		}
		//if the ship is above or below the screen, move its position to its opposite x value
		if (currentPosition.x > topRight.x || currentPosition.x < bottomLeft.x) {
			currentPosition.x = -currentPosition.x;

		}
		//if the ship is to the right or left of the screen, move its position to the opposite y value (plus variance to
		//line up with the screen border
		if (currentPosition.y > topRight.y || currentPosition.y < bottomLeft.y) {
			currentPosition.y = -(currentPosition.y - 2);

		}
		//move the ship to the new position
		transform.localPosition = currentPosition;
	
	}
}
