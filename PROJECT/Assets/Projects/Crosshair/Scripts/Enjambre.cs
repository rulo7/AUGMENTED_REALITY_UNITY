using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Enjambre : MonoBehaviour
{

	private Vector3 velocidadX = new Vector3 (0.5f, 0.0f, 0.0f);
	private Vector3 velocidadY = new Vector3 (0.0f, 0.0f, 0.4f);
	private float lastTime;
	private float ancho = 2.0f;
	private float waitTime = 1.0f;
	private int invadersKilleds;
	private int n;
	private int lastInvader;
	public Enjambre ()
	{
		Debug.Log ("constructor script");
	}

	public bool isExterminated ()
	{
		return (this.invadersKilleds == this.n);
	}

	public void DestroyInvader (int id)
	{
		if (id != lastInvader) {
			invadersKilleds++;
			Debug.Log ("Destroyed invader: " + invadersKilleds + " with ID: " + id);
			GameManager.instance.addPoints (100);
			lastInvader = id;
		}
	}



	// Use this for initialization
	void Start ()
	{
		this.invadersKilleds = 0;
		Debug.Log ("start enjambre");
		this.n = 6;
		Vector3 aux = this.transform.position;
		GameObject invader = (GameObject)Resources.Load ("Invader_1a");
		for (int i = 0; i < n; i++) {
			GameObject o = Instantiate (invader); // instantiate prefab and get its transform
			Transform t = o.transform;
			t.position = aux;
			t.parent = transform; // group the instance under the spawner
			aux.x += 4;
		}
		lastTime = Time.time;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameManager.instance.displayedTarget) {

			if (transform.localPosition.x >= ancho || transform.localPosition.x <= -ancho) {
				velocidadX.x *= -1;
				Vector3 aux = transform.position - velocidadY;
				transform.position = aux;
				transform.position += velocidadX;
			} else if (Time.time - lastTime > waitTime) {
				Debug.Log (transform.localPosition);
				transform.position += velocidadX;
				lastTime = Time.time;
			}
		} 
	}
}
