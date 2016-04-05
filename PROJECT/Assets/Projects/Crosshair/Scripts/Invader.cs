using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;
public class Invader : MonoBehaviour
{
	
	public GameObject projPrefab;
	private float lastTime;
	private Vector3 projAngle = new Vector3 (0.0f, 0.0f, -1.0f);
	private float SHOOT_INTERVAL = 2.0f;
	public int speed = 5;
	// Use this for initialization
	void Start ()
	{
		this.lastTime = Time.time;
		
	}
	void OnCollisionEnter (Collision other)
	{
		this.gameObject.transform.parent.GetComponent<Enjambre> ().DestroyInvader (this.GetInstanceID ());
		Destroy (gameObject);
		Destroy (other.gameObject);
	}
	// Update is called once per frame
	void Update ()
	{
		if (Time.time - this.lastTime > SHOOT_INTERVAL) {
			this.lastTime = Time.time;
			if (Random.Range (0.0f, 1.0f) < 0.10) { // 10% de posibilidades de disparar
				Vector3 posAux = this.gameObject.transform.position;
				posAux.y += this.gameObject.transform.lossyScale.y * 10;
				Quaternion rotAux = Quaternion.identity;
				GameObject projectile = Instantiate (projPrefab, posAux, rotAux) as GameObject;
				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = projAngle * speed;			
			}
		}
	}
}
