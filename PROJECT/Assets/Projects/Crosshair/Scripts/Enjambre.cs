using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Enjambre : MonoBehaviour
{

	[Header("Movimiento")]
	public Vector3
		horizontalSpeed = new Vector3 (0.5f, 0.0f, 0.0f);
	public Vector3 verticalSpeed = new Vector3 (0.0f, 0.0f, 0.4f);

	public float anchoSeparacion = 15.0f;
	public float altoSeparacion = 10.0f;

	public float waitTime = 1.0f;

	[Header("Invaders")]
	public GameObject
		invaderPrefab;
	public int nInvaders = 9;
	public int filas = 3;
	private int lastInvader;
<<<<<<< HEAD
	private float lastTime;

	private int
		invadersKilleds = 0;

=======
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
	
	
	
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
	// Use this for initialization
	void Start ()
	{

		Vector3 aux = this.transform.position;
<<<<<<< HEAD
		aux.z += (altoSeparacion * filas);
		aux.x -= anchoSeparacion * ((this.nInvaders / filas) / 2);
=======
		aux.z += 5 * filas;
		aux.x -= 4 * ((this.n / filas) / 2);
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
		float firstX = aux.x;

		GameObject o;
		Transform t;
		for (int j = 0; j < filas; j++) {
			for (int i = 0; i < (this.nInvaders / filas); ++i) {
				o = Instantiate (invaderPrefab); // instantiate prefab and get its transform
				t = o.transform;
				t.position = aux;
				t.parent = transform; // group the instance under the spawner
<<<<<<< HEAD
				aux.x += anchoSeparacion;
			}
			aux.z -= altoSeparacion;
=======
				aux.x += 4;
			}
			aux.z -= 5;
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
			aux.x = firstX;
		}		
		lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameManager.instance.displayedTarget) {
			if (transform.localPosition.x >= anchoSeparacion || transform.localPosition.x <= -anchoSeparacion) {
				horizontalSpeed.x *= -1; // cambiamos el sentido
				Vector3 aux = transform.position - verticalSpeed;
				transform.position = aux;
				transform.position += horizontalSpeed;
			} 
			if (Time.time - lastTime > waitTime) {
				transform.position += horizontalSpeed;
				lastTime = Time.time;
			}
		} 
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
	public bool isExterminated ()
	{
		return (this.invadersKilleds == this.nInvaders);
	}

}
