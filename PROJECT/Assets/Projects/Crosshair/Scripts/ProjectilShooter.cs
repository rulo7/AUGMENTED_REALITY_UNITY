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
		
	}
}
