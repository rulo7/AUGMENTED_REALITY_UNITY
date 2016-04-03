using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;
public class Invader : MonoBehaviour
{

	GameObject invader;

	// Use this for initialization
	void Start ()
	{
	
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
		/*	bool displayed = false;
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb is TextTracker && tb.name == "Informatica")
				displayed = true;
		}
		if (displayed) {
			GameObject inv = Instantiate (invader) as GameObject;
			Vector3 aux = this.transform.position;
			aux.y -= 10;
			inv.transform.position = aux;

		}*/
	}
}
