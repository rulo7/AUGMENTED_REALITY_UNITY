using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{

	public    GameObject shot;
	private LineRenderer line;
	void Start ()
	{
		line = GetComponent<LineRenderer> ();
		line.enabled = false;
	}
	// Update is called once per frame
	void Update ()
	{
		// probar a trampear con una buena foto y volver a imageTarget
		// mantener texto y dibujar un rayo láser y hacer un pequeño efecto de explosión o de lanzamiento del rayo
		if (GameManager.instance.CanShoot ()) {
			if (!line.enabled)
				line.enabled = true;
			if (Input.GetMouseButtonDown (0)) {
				RaycastHit hit;
				//Camera c = GameManager.instance.getCamera ();
				Ray ray = Camera.main.ScreenPointToRay (new Vector3 ((Screen.width / 2), (Screen.height / 2), 0));
				if (Physics.Raycast (ray, out hit)) {
					hit.collider.SendMessage ("OnCollisionEnter", this);

					Debug.Log (hit.collider.gameObject.name.ToString ());
				}
				/*  GameObject projectile = Instantiate(shot, transform.position + transform.forward * 2, transform.rotation) as GameObject;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 2000);*/

			}
		}
	}
}
