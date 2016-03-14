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
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb is ImageTargetBehaviour && tb.name == "qrGrisIT")
				displayedTarget = true;
		}
		if (displayedTarget) {
			crosshair.SetActive (true);
			//GameObject.Find ("txtScore").SetActive (true);
			//GameObject.Find ("txtStart").SetActive (true);
			GameObject.Find ("txtScore").GetComponent<Text> ().enabled = true;
			GameObject.Find ("txtStart").GetComponent<Text> ().enabled = true;
		}
	}
	public void DeathZoneEnter ()
	{
		Debug.Log ("Game lost!");
	}

	public void DestroyInvader (int id)
	{
		if (id != lastInvader) {
			destroyedInvaders++;
			Debug.Log ("Destroyed invader: " + destroyedInvaders + " with ID: " + id);
			puntos += 100;

			GameObject.Find ("txtScore").GetComponent<Text> ().text = "SCORE: " + puntos;
			lastInvader = id;
		}
	}
	// Update is called once per frame
	void Update ()
	{
		if (!end) {
			if (displayedTarget) {
				if (destroyedInvaders == NUM_ENEMIES) {
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
