using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class WordsContainer : MonoBehaviour
{
	public GameObject objectToDisplay;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool displayed = false, displayed2 = false;
		Vector3 v1 = new Vector3 (0, 0);
		Vector3 v2 = new Vector3 (0, 0, 0);
		StateManager sm = TrackerManager.Instance.GetStateManager ();

		IEnumerable<WordResult> activeWords = sm.GetWordManager ().GetActiveWordResults ();

		foreach (WordResult wr in activeWords) {
			if (wr.Word.Name.ToLower () == "informatica") {
				displayed = true;
				v1 = wr.Position;
				//Debug.Log ("Encontrado informatica");
			} 
			if (wr.Word.Name.ToLower () == "facultad") {
				displayed2 = true;
				//Debug.Log ("Encontrado facultad");
				v2 = wr.Position;
			}
		}
		if (displayed && displayed2) {
			GameObject inv = Instantiate (objectToDisplay) as GameObject;

			Vector3 aux = (v1 + v2) / 2;

			inv.transform.position = aux;

		}
	}
}
