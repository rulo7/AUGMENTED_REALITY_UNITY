using UnityEngine;
using System.Collections;

public class StartAnim : MonoBehaviour {

    private TimeController _tc;
    private Animator _anim;

	// Use this for initialization
	void Start () {
        _tc = GetComponent<TimeController>();
        _anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

       
	
	}
}
