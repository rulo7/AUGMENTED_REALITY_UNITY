using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{

	public    GameObject shot;
	private LineRenderer line;
	private 		AudioSource audioS;
	// web http://soundbible.com/472-Laser-Blasts.html
	// explosion http://soundbible.com/1234-Bomb.html
	void Start ()
	{
		line = GetComponent<LineRenderer> ();
		line.enabled = false;
		audioS = GetComponent<AudioSource> ();
	}
	// Update is called once per frame
	private void Shoot ()
	{
		RaycastHit hit;
		//Camera c = GameManager.instance.getCamera ();
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 ((Screen.width / 2), (Screen.height / 2), 0));
		audioS.Play ();
		if (Physics.Raycast (ray, out hit)) {
			//hit.collider.SendMessage ("OnCollisionEnter", this);			
			Invader i = hit.collider.gameObject.GetComponentInParent<Invader> ();
			if (i != null) {
				i.Hit ();
			}
			//hit.collider.BroadcastMessage ("OnCollisionEnter", this);
			Debug.Log (hit.collider.gameObject.name.ToString ());

		}
	}
	void Update ()
	{
		// probar a trampear con una buena foto y volver a imageTarget
		// mantener texto y dibujar un rayo láser y hacer un pequeño efecto de explosión o de lanzamiento del rayo
		if (GameManager.instance.CanShoot ()) {
			if (!line.enabled)
				line.enabled = true;
			if (Input.GetMouseButtonDown (0)) {
				Shoot ();
				/*  GameObject projectile = Instantiate(shot, transform.position + transform.forward * 2, transform.rotation) as GameObject;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 2000);*/

			}
		}
	}
}
