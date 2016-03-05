using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour {
	public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 shipPosition;
		shipPosition = transform.position;
		//on space press Down, create a bullet object
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, new Vector3 (shipPosition.x, shipPosition.y, 0), Quaternion.identity);
		}
	}
}
