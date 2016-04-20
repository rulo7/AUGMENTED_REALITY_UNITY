using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class ShowScoreLayoutListener : MonoBehaviour {

	public Text resultLabel;

	void Start(){
		getScore ();
	}

	private void getScore(){
		StartCoroutine(WaitForRequest(RestApi.getInstance().getScores()));
	}

	private IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null)
		{
			UsersEntity usersEntity = JsonUtility.FromJson<UsersEntity>(www.text);
			resultLabel.text = "";
			for (int i= 0; i < usersEntity.users.Length ; i++) {
				UsersEntity.UserEntity user = usersEntity.users[i];
				resultLabel.text += user.name + ":\t" + user.score + "\n";
			}


		} else {
			resultLabel.text = "There was an error and the scores couldn't be showed";
			Debug.Log(www.error);
		}
	}

	[Serializable]
	public class UsersEntity{
		[SerializeField]
		public UserEntity[] users;
		public class UserEntity{
			public int id;
			public string name;
			public int score;
		}
	}
}