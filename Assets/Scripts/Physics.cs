using UnityEngine;
using System.Collections;

public class Physics : MonoBehaviour {
	
	private static float gravity = 9.81f;	// Earths gravity, change to 1.66 (Moons gravity)
	private float jumpSpeed;
	private bool isGrounded;
	
	// Use this for initialization
	void Start () {
		isGrounded = true;
		jumpSpeed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
			jumpSpeed = 10f;
		
		if (!isGrounded) 
			jumpSpeed -= gravity*Time.deltaTime;
		
		transform.position += new Vector3(0, Time.deltaTime*jumpSpeed, 0);
	}
	
	void OnTriggerEnter() {
		jumpSpeed = 0f;	
		isGrounded = true;
	}
	
	void OnTriggerStay(Collider other) {	// Checks if the gameObject is colliding with the floor.
		if (other.gameObject.name.Equals("Floor"))
			isGrounded = true;
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject.name.Equals("Floor"))
			isGrounded = false;
	}
}
