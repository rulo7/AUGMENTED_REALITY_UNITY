using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Enjambre : MonoBehaviour
{

	private Vector3 velocidadX = new Vector3 (0.1f, 0.0f, 0.0f);
	private Vector3 velocidadY = new Vector3 (0.0f, 0.1f, 0.0f);
	private float lastTime;
	private float ancho = 0.2f;
	private float waitTime = 1.0f;
	private bool displayed = false;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("start enjambre");
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
