using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Application.LoadLevel("water");
                    break;
            }
        }

    }
}
