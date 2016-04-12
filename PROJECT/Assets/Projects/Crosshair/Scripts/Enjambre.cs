using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Enjambre : MonoBehaviour
{
	
	private Vector3 velocidadX = new Vector3 (0.5f, 0.0f, 0.0f);
	private Vector3 velocidadY = new Vector3 (0.0f, 0.0f, 0.4f);
	private float lastTime;
	private float ancho = 1.5f;
	private float waitTime = 1.0f;
	private int invadersKilleds;
	private int n;
	private int lastInvader;
	public GameObject invader;
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
		this.n = 9;
		int filas = 3;
		Vector3 aux = this.transform.position;
		aux.z += 5 * filas;
		aux.x -= 4 * ((this.n / filas) / 2);
		float firstX = aux.x;

		for (int j = 0; j < filas; j++) {
			for (int i = 0; i < (this.n / filas); ++i) {
				GameObject o = Instantiate (invader); // instantiate prefab and get its transform
				Transform t = o.transform;
				t.position = aux;
				t.parent = transform; // group the instance under the spawner
				aux.x += 4;
			}
			aux.z -= 5;
			aux.x = firstX;
		}
		
		lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameManager.instance.displayedTarget) {
			if (transform.localPosition.x >= ancho || transform.localPosition.x <= -ancho) {
				velocidadX.x *= -1; // cambiamos el sentido
				Vector3 aux = transform.position - velocidadY;
				transform.position = aux;
				transform.position += velocidadX;
			} 
			if (Time.time - lastTime > waitTime) {
				transform.position += velocidadX;
				lastTime = Time.time;
			}
		} 
	}
}
