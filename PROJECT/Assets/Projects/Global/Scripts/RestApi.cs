using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RestApi {
	private const string USERNAME = "api_user";
	private const string USERPASSWORD = "userpass";
	private const string URLBASE= "http://augmentedreality.hol.es";

	private static RestApi instance;

	public static RestApi getInstance(){
		if (instance == null)
			instance = new RestApi ();
		return instance;
	}

	private Dictionary<string,string> getAuthenticationHeader(){
		Dictionary<string,string> headers = new WWWForm().headers;
		headers["Authorization"] = "Basic " + System.Convert.ToBase64String(
			System.Text.Encoding.ASCII.GetBytes(USERNAME + ":" + USERPASSWORD));
		return headers;
	}

	public WWW postScore(string name, int score){
		WWWForm form =  new WWWForm();
		form.AddField ("user[name]",name);
		form.AddField ("user[score]",score);
		return new WWW(URLBASE + "/api/users", form.data, getAuthenticationHeader());
	}

	public WWW getScores(){
		return new WWW(URLBASE + "/api/users.json", null, getAuthenticationHeader());
	}
}
