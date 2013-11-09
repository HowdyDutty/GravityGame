using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public GameObject lockBullet;
	public GameObject gravityBullet;
	public GameObject tipOfGun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown("Fire1")) {
			// Spawns a lock bullet at the empty gameObject in front of the gun.
			Instantiate(lockBullet, tipOfGun.transform.position, transform.rotation);	
		}
		
		if (Input.GetButtonDown("Fire2")) {
			// Spawns a gravity bullet at the empty gameObject in front of the gun.
			Instantiate(gravityBullet, tipOfGun.transform.position, transform.rotation);
		}
	}
}
