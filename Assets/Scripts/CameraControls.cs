using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {
	
	public Transform player;
	
	public float smoothRate;
	private Vector2 velocity = new Vector2(0.5f, 0.5f);
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 newPos2D = Vector2.zero;	// Initializes the 2d position of the camera.
		
		// Finds the location of the target on the x & y axis.
		newPos2D.x = Mathf.SmoothDamp(transform.position.x, player.position.x, ref velocity.x, smoothRate);
		newPos2D.y = Mathf.SmoothDamp(transform.position.y, player.position.y + 5f, ref velocity.y, smoothRate);
		
		// Stores where the camera needs to go.
		Vector3 newPos = new Vector3(newPos2D.x, newPos2D.y , transform.position.z);
		
		// Transforms the position of the camera from its initial location to the new location over time.
		transform.position = Vector3.Slerp(transform.position, newPos, Time.time);
	}
}
