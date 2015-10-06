using UnityEngine;
using System.Collections;

public class lerpyMover : MonoBehaviour {

	private Transform startPoint, endPoint;

	public float percentage;
	public float speed = 2;
	private int direction;

	// Use this for initialization
	void Start () {
		startPoint = GameObject.Find ("startPoint").transform;
		endPoint = GameObject.Find ("endPoint").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		transform.rotation = Quaternion.Lerp (Quaternion.identity, Quaternion.Euler (new Vector3 (-90, 120, 3)), percentage);

		gameObject.GetComponent<Renderer> ().material.color = Color.Lerp (Color.blue, Color.green, percentage);

		if (speed == 0)
			speed = .000001f;
		percentage += Time.deltaTime/speed * direction;

		//keep percentage within range
		if (percentage>1) {
			direction = -1;
		}
		if (percentage < 0) {
			direction = 1;
		}

		//switch direction
	}
}
