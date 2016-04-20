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
<<<<<<< HEAD
=======
	public GameObject enjambre;
	public GameObject shot;
	public GameObject defensas;
	private GameObject crosshair;

	
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
	private int puntos = 0;

	// se settean al llamarse a startGame
	private GameObject
		enjambre;
	private GameObject mainCamera;
	private GameObject defensas;
	[Header("Prefabs")]
	public GameObject
		shot;

	[Header("UI")]
	public GameObject
		canvasCrosshair;
	public GameObject txtScore;
	public GameObject txtStart;
	public GameObject txtWin;

	private Transform informaticaText;
	private Transform posDefenses;
	public Transform getTextTransform ()
	{
		return informaticaText;
	}

	// Use this for initialization
	void Start ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		Setup ();
	}

	void Setup ()
	{
<<<<<<< HEAD
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
=======
		
		// Cargamos el GameObject del crosshair y lo desactivamos
		crosshair = GameObject.Find ("CanvasCrosshair");
		crosshair.SetActive (false);
		

		// comprobamos si esta el target a la vista
		checkForTarget ();
		
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
	}
	/// <summary>
	/// Win the game.
	/// </summary>
	void WinGame ()
	{
		Debug.Log ("Win game!");
		txtWin.GetComponent<Text> ().enabled = true;
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
		canvasCrosshair.SetActive (false);
		DestroyObject (canvasCrosshair);
	}
<<<<<<< HEAD

	public Transform getTransformDef ()
	{
		return defensas.transform;
=======
	public void checkForTarget ()
	{
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb is ImageTargetBehaviour && tb.name == "qrGrisIT") {
				displayedTarget = true;
				enjambre = Instantiate (enjambre); // instantiate prefab and get its transform
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
			defensas = Instantiate (defensas);
			GameObject.Find ("txtScore").GetComponent<Text> ().enabled = true;
			GameObject.Find ("txtStart").GetComponent<Text> ().enabled = true;
		}
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
	}

	public void startGame (Transform childEnjambre, Transform childDefensas, Transform text)
	{
		enjambre = childEnjambre.gameObject;
		defensas = childDefensas.gameObject;
		enjambre.SetActive (true);
		defensas.SetActive (true);
		informaticaText = text;
		// UI
		canvasCrosshair.SetActive (true);
		txtScore.GetComponent<Text> ().enabled = true;
		txtStart.GetComponent<Text> ().enabled = true;
		displayedTarget = true;
	}

	public void addPoints (int points)
	{
		this.puntos += points;
		txtScore.GetComponent<Text> ().text = "SCORE: " + puntos;
	}
	private void Shoot ()
	{		
		// cogemos una posicion un pelin por delante de la camara, si no se veria como que el disparo "sale" de nosotros
		Vector3 position = mainCamera.transform.position + mainCamera.transform.forward * 2; 
		Quaternion rotation = mainCamera.transform.rotation;
		GameObject projectile = Instantiate (shot, position, rotation) as GameObject;

		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = mainCamera.transform.forward * 40;		
	}
	// Update is called once per frame
	void Update ()
	{
<<<<<<< HEAD
		if (CanShoot ()) {
			if (Input.GetMouseButtonDown (0))
				Shoot ();				
			if (enjambre.GetComponent<Enjambre> ().isExterminated ()) {
				WinGame ();
			}												
=======
		if (!end) {
			if (displayedTarget) {
				if (Input.GetMouseButtonDown (0))
					Shoot ();
				
				if (enjambre.GetComponent<Enjambre> ().isExterminated ()) {
					WinGame ();
				}
				
				
				
			} else
				checkForTarget ();
>>>>>>> ed41e0c00c119eba18f56826629956ca70bc9c0a
		}
	}
	
	public bool CanShoot ()
	{
		return (!end && displayedTarget);
	}
}
