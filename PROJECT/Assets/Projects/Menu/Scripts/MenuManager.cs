using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void runGame(){
		GlobalGameManager.getInstance().loadInit ();
	}

	public void showScores(){
		GlobalGameManager.getInstance().loadScores();
	}

	public void showAbout(){
		//ToDo
	}

	public void Exit(){
		Application.Quit();
	}
}
