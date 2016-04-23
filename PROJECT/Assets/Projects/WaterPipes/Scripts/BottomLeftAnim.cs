using UnityEngine;
using System.Collections;

public class BottomLeftAnim : MonoBehaviour {

    private Animator _anim;
    private WaterController _wc;
    public int dire;
    public bool water;
    

	// Use this for initialization
	void Start () {
        _wc = GetComponent<WaterController>();
        _anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        _anim.SetInteger("dire", dire);
        _anim.SetBool("water", water);
	
	}
}
