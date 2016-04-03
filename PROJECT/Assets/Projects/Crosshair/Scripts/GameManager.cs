using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;
	public bool displayedTarget = false;
	public bool end = false;
	public int NUM_ENEMIES = 6;
	private GameObject enjambre;
	private int destroyedInvaders = 0;
	private GameObject crosshair;
	private int lastInvader = 0;
	private int puntos = 0;
	// Use this for initialization
	void Start ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		Setup ();
	}
	/// <summary>
	/// Setup this instance.
	/// </summary>
	void Setup ()
	{

		// Cargamos el GameObject del crosshair y lo desactivamos
		crosshair = GameObject.Find ("CanvasCrosshair");
		crosshair.SetActive (false);


		// comprobamos si esta el target a la vista
		checkForTarget ();

	}

	/// <summary>
	/// Win the game.
	/// </summary>
	void WinGame ()
	{
		Debug.Log ("Win game!");
		GameObject.Find ("txtWin").GetComponent<Text> ().enabled = true;
		EndGame ();
	}
	/// <summary>
	/// Losts the game.
	/// </summary>
	void LostGame ()
	{
		Debug.Log ("Lost game!");
		EndGame ();
	}
	/// <summary>
	/// Ends the game. Hace todo lo que se debe hacer para ambos casos, perder o ganar.
	/// </summary>
	private void EndGame ()
	{
		end = true;
		crosshair.SetActive (false);
		DestroyObject (crosshair);
	}
	public void checkForTarget ()
	{
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
		Vector3 aux;
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb is ImageTargetBehaviour && tb.name == "qrGrisIT") {
				aux = tb.gameObject.transform.position;
				displayedTarget = true;
				enjambre = Instantiate ((GameObject)Resources.Load ("Enjambre")); // instantiate prefab and get its transform
				enjambre.transform.parent = tb.gameObject.transform; // group the instance under the spawner
				enjambre.transform.position = tb.gameObject.transform.position;
				enjambre.transform.localRotation = Quaternion.identity;
				Debug.Log (enjambre.transform.rotation);
				Debug.Log (tb.gameObject.transform.rotation);
				break;
			}
		}
		if (displayedTarget) {
			crosshair.SetActive (true);
			// Creamos todos los invaders

			GameObject.Find ("txtScore").GetComponent<Text> ().enabled = true;
			GameObject.Find ("txtStart").GetComponent<Text> ().enabled = true;
		}
	}
	public void DeathZoneEnter ()
	{
		Debug.Log ("Game lost!");
	}
	public void addPoints (int points)
	{
		this.puntos += points;
		GameObject.Find ("txtScore").GetComponent<Text> ().text = "SCORE: " + puntos;
	}
	// Update is called once per frame
	void Update ()
	{
		if (!end) {
			if (displayedTarget) {
				if (destroyedInvaders == NUM_ENEMIES || enjambre.GetComponent<Enjambre> ().isExterminated ()) {
					Debug.Log (enjambre.GetComponent<Enjambre> ().isExterminated ());
					WinGame ();
				}
			} else
				checkForTarget ();
		}
	}

	public bool CanShoot ()
	{
		return (!end && displayedTarget);
	}
}
