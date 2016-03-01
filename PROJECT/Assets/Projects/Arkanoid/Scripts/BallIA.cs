using UnityEngine;
using System.Collections;

public class BallIA : MonoBehaviour {

	public int forceX;
	public int forceY;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX,forceY));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
