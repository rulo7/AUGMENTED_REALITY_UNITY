using UnityEngine.UI;
using UnityEngine;

public class OnClickListenerSendButton : MonoBehaviour{

	public InputField input;
	public ClientApi clientApi;

	public void OnClick(){
		Debug.Log ("On Click");
		clientApi.postScore(input.text,ScoreManager.getInstance().getGameScore());
	}
}
