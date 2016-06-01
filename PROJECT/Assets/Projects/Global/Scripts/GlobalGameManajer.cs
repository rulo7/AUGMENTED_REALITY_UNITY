using UnityEngine;
using System.Collections;

public class GlobalGameManager : MonoBehaviour {

	private static GlobalGameManager instance;

	public static GlobalGameManager getInstance(){
		if (instance== null){
			GameObject go = new GameObject();
			instance = go.AddComponent<GlobalGameManager>();
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
        Application.LoadLevel ("water");
		unloadActiveScene();
	}

    public void loadInit()
    {
        Application.LoadLevel("Init scene");
        unloadActiveScene();
    }

    public void loadCrossHairArkanoid()
    {
        Application.LoadLevel("Crosshair-Arkanoid scene");
        unloadActiveScene();
    }

    public void loadArkanoidWaterPipes()
    {
        Application.LoadLevel("Arkanoid-Waterpipes scene");
        unloadActiveScene();
    }

	public void loadScores()
	{
		Application.LoadLevel("ScoresScene");
		unloadActiveScene();
	}

	public void loadMenu()
	{
		Application.LoadLevel("MenuScene");
		unloadActiveScene();
	}

    private void unloadActiveScene(){
		Application.UnloadLevel(Application.loadedLevelName);
	}
}
