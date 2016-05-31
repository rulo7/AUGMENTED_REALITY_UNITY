using UnityEngine;
using System.Collections;

public class e : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("ARCamera").GetComponent<TouchObject>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
