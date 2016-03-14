using UnityEngine;
using System.Collections;

public class BallIA : MonoBehaviour {

	public int forceX;
	public int forceY;

	private bool started = false;
		
	// Update is called once per frame
	void Update () {
		if(!started && Input.touches.Length > 0){
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX,forceY));
			started = true;
		}
	}
}
