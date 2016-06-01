using UnityEngine;
using System.Collections;

public class ExitOnBack : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			GlobalGameManager.getInstance ().loadMenu();
		//Application.Quit(); 
	}
}
