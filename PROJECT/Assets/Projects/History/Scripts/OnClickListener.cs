using UnityEngine;
using System.Collections;

public class OnClickListener : MonoBehaviour {

    public enum Scenes{CROSSHAIR,WATERPIPES,ARKANOID}
    public Scenes scene;
    private bool isTouched = false;
	public GameObject loadingPanel;

	public void Update () {
        if (!isTouched) {
            foreach (Touch touch in Input.touches)
            {
                switch (touch.phase)
                {
				case TouchPhase.Began:
					if (loadingPanel != null)
						this.gameObject.SetActive (false);
						loadingPanel.SetActive (true);
                        switch (scene)
                        {
                            case Scenes.CROSSHAIR:
                                GlobalGameManager.getInstance().loadCrosshair();
                                return;
                            case Scenes.ARKANOID:
                                GlobalGameManager.getInstance().loadArkanoid();
                                return;
                            case Scenes.WATERPIPES:
                                GlobalGameManager.getInstance().loadWaterPipes();
                                return;
                        }
                        isTouched = true;
                        return;
                }
            }
        }
	}
}
