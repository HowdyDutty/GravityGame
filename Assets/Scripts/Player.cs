using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float moveSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3(Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime, 0, 0);
	
	}
}
