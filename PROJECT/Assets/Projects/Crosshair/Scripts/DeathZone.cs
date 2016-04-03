using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}

	void OnCollisionEnter (Collision other)
	{


		if (other.gameObject.name.Contains ("Invader_"))
			GameManager.instance.DeathZoneEnter ();

		
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
