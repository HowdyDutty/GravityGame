using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 moveDirection = Vector2.up * moveSpeed * Time.deltaTime;
		
		transform.Translate(moveDirection);
	
	}
	
	void OnTriggerEnter() {
		Destroy(this.gameObject);	 //If it collides with something.
	}
}
