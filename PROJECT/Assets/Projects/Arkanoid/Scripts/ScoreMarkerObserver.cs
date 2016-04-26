using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMarkerObserver : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text>().text = "score: " + ScoreManager.getInstance().getGameScore();
	}
}
