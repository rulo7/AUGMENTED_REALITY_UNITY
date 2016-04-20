using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class OnClickListenerSendButton : MonoBehaviour{

	public InputField input;
	public List<GameObject> objectsToEnable;
	public List<GameObject> objectsToDisable;

	public void OnClick(){
		StartCoroutine(WaitForRequest(RestApi.getInstance().postScore(input.text,ScoreManager.getInstance().getGameScore())));
	}
		
	private IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null)
		{
			foreach(GameObject g in objectsToEnable){
				g.SetActive (true);
			}

			foreach(GameObject g in objectsToDisable){
				g.SetActive (false);
			}
		} else {
			UnityEditor.EditorUtility.DisplayDialog ("There was an error","The score couldn't be send", "Close",null);
			Debug.LogError(www.error);
		}
			
	}
}
