using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 moveDirection = new Vector3(Time.deltaTime*moveSpeed, Time.deltaTime*moveSpeed, 0);
		
		transform.Translate(moveDirection);
	
	}
	
	void OnTriggerEnter() {
		Destroy(this.gameObject);	 //If it collides with something.
	}
}
