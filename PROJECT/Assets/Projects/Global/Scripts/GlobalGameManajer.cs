using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
		SceneManager.LoadScene ("ArkanoidScene");
		unloadActiveScene();
	}

	public void loadCrosshair(){
		SceneManager.LoadScene ("crosshair");
		unloadActiveScene();
	}

	public void loadWaterPipes(){
		SceneManager.LoadScene ("menu");
		unloadActiveScene();
	}

	private void unloadActiveScene(){
		SceneManager.UnloadScene (SceneManager.GetActiveScene().name);
	}
}
