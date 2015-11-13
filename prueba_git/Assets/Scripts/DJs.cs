using UnityEngine;
using System.Collections;

public class DJs : MonoBehaviour {
	public AudioClip sonido1;
	public AudioClip sonido2;
	public AudioClip sonido3;

	private AudioSource au;
	// Use this for initialization
	void Start () {
		au = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			au.PlayOneShot(sonido1,1);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			au.PlayOneShot(sonido2,1);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			au.PlayOneShot(sonido3,1);
		}
	
	}
}
