using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class ProjectilShooter : MonoBehaviour
{


	GameObject prefab;
	// Use this for initialization
	void Start ()
	{
		prefab = Resources.Load ("Projectil") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameManager.instance.CanShoot ()) {
			if (Input.GetMouseButtonDown (0) && GameManager.instance.displayedTarget) {
				GameObject projectile = Instantiate (prefab) as GameObject;
				//projectile.transform.position = transform.position +  Camera.main.transform.forward*2;
				projectile.transform.position = GameObject.FindGameObjectWithTag ("MainCamera").transform.position + GameObject.FindGameObjectWithTag ("MainCamera").transform.forward * 2;
				projectile.transform.rotation = GameObject.FindGameObjectWithTag ("MainCamera").transform.rotation;
				Debug.Log (projectile.transform.rotation);

				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = GameObject.FindGameObjectWithTag ("MainCamera").transform.forward * 40;
			}
		}
	}
}
