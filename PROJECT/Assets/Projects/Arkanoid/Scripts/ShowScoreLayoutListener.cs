using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;


public class ShowScoreLayoutListener : MonoBehaviour
{

	public Text resultLabel;

	void Start ()
	{
		getScore ();
	}

	private void getScore ()
	{
		StartCoroutine (WaitForRequest (RestApi.getInstance ().getScores ()));
	}

	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;

		if (www.error == null) {
			accessData(new JSONObject(www.text));
		} else {
			resultLabel.text = "There was an error and the scores couldn't be showed";
			Debug.Log (www.error);
		}
	}

	private void accessData(JSONObject obj){
		JSONObject users = obj.GetField("users");
		int i = 1;
		foreach(JSONObject j in users.list){
			resultLabel.text += i + " - " + j.GetField ("name").str + ": " + j.GetField ("score").n + "\n";
			i++;
		}
	}
}