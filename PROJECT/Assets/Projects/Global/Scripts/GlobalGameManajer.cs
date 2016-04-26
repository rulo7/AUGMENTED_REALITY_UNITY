using UnityEngine;
using System.Collections;

public class GlobalGameManajer : MonoBehaviour {

	private static GlobalGameManajer instance;

	public static GlobalGameManajer geInstance(){
		if (instance== null){
			GameObject go = new GameObject();
			instance = go.AddComponent<GlobalGameManajer>();
		}
		return instance;
	}

	public void loadArkanoid(){
		Application.LoadLevel ("ArkanoidScene");
		unloadActiveScene();
	}

	public void loadCrosshair(){
        Application.LoadLevel ("crosshair");
		unloadActiveScene();
	}

	public void loadWaterPipes(){
        Application.LoadLevel ("menu");
		unloadActiveScene();
	}

	private void unloadActiveScene(){
		Application.UnloadLevel(Application.loadedLevelName);
	}
}
