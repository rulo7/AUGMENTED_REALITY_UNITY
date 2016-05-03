using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeMarkerObserver : MonoBehaviour {
	private float timeLeft = 59;
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
			GlobalGameManager.getInstance().loadArkanoidWaterPipes ();
		else
			GetComponent<Text>().text = "Time: " + ((int)timeLeft);
	}
}
