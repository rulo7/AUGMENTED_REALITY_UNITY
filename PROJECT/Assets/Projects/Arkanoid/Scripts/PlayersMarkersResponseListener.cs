using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayersMarkersResponseListener : MonoBehaviour, ClientApi.ResponseWWWListener {

	public Text board;

	public void success (WWW www)
	{
		board.text = www.text;	
	}

	public void error (WWW www)
	{
		Debug.LogError (www.error);
		board.text = "Se produjo un error y no se tramitó la petición correctamente";
	}
}
