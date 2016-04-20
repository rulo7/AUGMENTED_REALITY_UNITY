using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;
public class Invader : MonoBehaviour
{
	[Header("Shoot")]
	public GameObject
		projPrefab;
	public float SHOOT_INTERVAL = 2.0f;
	public int speedProjectile = 5;
	public float shootingChance = 0.10f;

	private float lastTime;
	private Vector3 projAngle = new Vector3 (0.0f, 0.0f, -1.0f);
	
	// Use this for initialization
	void Start ()
	{
		this.lastTime = Time.time;
		
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag.Equals ("Player")) {
			this.gameObject.transform.parent.GetComponent<Enjambre> ().DestroyInvader (this.GetInstanceID ());
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
	// Update is called once per frame
	void Update ()
	{
		if (Time.time - this.lastTime > SHOOT_INTERVAL) {
			this.lastTime = Time.time;
			if (Random.Range (0.0f, 1.0f) < shootingChance) { // 10% de posibilidades de disparar cada 2 segundos
				Vector3 posAux = this.gameObject.transform.position;
				posAux.y = GameManager.instance.getTransformDef ().position.y; // mejor usar raycast entre invader y defensas?
				Quaternion rotAux = Quaternion.identity;
				GameObject projectile = Instantiate (projPrefab, posAux, rotAux) as GameObject;
				projectile.transform.parent = GameManager.instance.getTextTransform ();
				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = projAngle * speedProjectile;			
			}
		}
	}
}
