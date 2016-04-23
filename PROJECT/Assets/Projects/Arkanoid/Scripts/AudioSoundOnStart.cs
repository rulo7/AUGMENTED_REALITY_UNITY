using UnityEngine;
using System.Collections;

public class AudioSoundOnStart : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource.Play ();
	}

}
