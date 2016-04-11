using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class ClientApi : MonoBehaviour{

	private const string USERNAME = "api_user";
	private const string USERPASSWORD = "userpass";

	public void postScore(string name, int score){
		WWWForm form =  new WWWForm();
		form.AddField ("user[name]",name);
		form.AddField ("user[score]",score);

		Dictionary<string,string> headers = form.headers;
		headers["Authorization"] = "Basic " + System.Convert.ToBase64String(
			System.Text.Encoding.ASCII.GetBytes(USERNAME + ":" + USERPASSWORD));

		WWW w = new WWW("http://localhost:8080/projects/api_rest/web/app_dev.php/api/users.json", form.data, headers);
	
		StartCoroutine(WaitForRequest(w));
	}

	private IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
