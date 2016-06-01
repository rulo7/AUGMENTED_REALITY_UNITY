using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class OnClickListenerSendButton : MonoBehaviour{

	public InputField input;

	public void OnClick(){
		if (input.text == null || input.text.Length <= 0) {
			input.text = "El nombre no puede ser vacío";
			return;
		}
			
		GetComponent<Button> ().interactable = false;
		string name = input.text;
		StartCoroutine(WaitForRequest(RestApi.getInstance().postScore(name,ScoreManager.getInstance().getGameScore())));
		input.text = "loading...";
	}
		
	private IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null)
		{
			GlobalGameManager.getInstance ().loadScores ();
		} else {
			//UnityEditor.EditorUtility.DisplayDialog ("There was an error","The score couldn't be send", "Close",null);
			Debug.LogError(www.error);
		}
			
	}
}
