using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class SonidoBalon : MonoBehaviour {


	private AudioSource sonido;


	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	
	}
	void OnCollisionEnter2D(Collision2D objeto){
		sonido.Play ();
		Debug.Log ("play");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
