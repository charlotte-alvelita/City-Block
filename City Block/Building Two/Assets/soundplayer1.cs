using UnityEngine;
using System.Collections;

public class soundplayer1 : MonoBehaviour {

	private AudioSource woosh_sound;

	
	void Start () {
		woosh_sound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && woosh_sound.isPlaying == false) {
			gameObject.GetComponent<AudioSource> ().Play ();
		}
	}
}
