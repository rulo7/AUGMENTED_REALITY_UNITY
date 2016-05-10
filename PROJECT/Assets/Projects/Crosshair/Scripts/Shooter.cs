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
		/*line = gameObject.AddComponent<LineRenderer> ();	*/
		line.SetWidth (0.2f, 0.2f);
		line.enabled = false;

		audioS = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	private void Shoot ()
	{
		RaycastHit hit;
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
			//Vector3 startPnt = this.transform.position;
			Vector3 endPnt = new Vector3 (Screen.width / 2, Screen.height / 2, GameManager.instance.getCamera ().transform.position.z);
			//line.SetPosition (0, startPnt);
			line.SetPosition (1, endPnt);
			if (Input.GetMouseButtonDown (0)) {
				Shoot ();

			}
		}
	}
}
