using UnityEngine;
using System.Collections;

public class MainOnBack : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			GlobalGameManager.getInstance ().loadMenu();
	}
}
