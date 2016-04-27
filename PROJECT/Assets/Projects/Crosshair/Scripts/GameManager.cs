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
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
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
	public void LostGame ()
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
		enjambre.SetActive (false);
		defensas.SetActive (false);
        GlobalGameManager.getInstance().loadCrossHairArkanoid();
	}
	
	public Transform getTransformDef ()
	{
		return defensas.transform;
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

	
	// Update is called once per frame
	void Update ()
	{
		if (CanShoot ()) {
			
				
			if (enjambre.GetComponent<Enjambre> ().isExterminated ()) {
				WinGame ();
			}												
		}
	}
	
	public bool CanShoot ()
	{
		return (!end && displayedTarget);
	}
}