using UnityEngine;
using System.Collections;

public class OnDragPlatformImp : MonoBehaviour, ScreenDragListener.OnDragListener {
	
	private float c = 1f;
	private float width;

	public string anchorRightTag;
	public string anchorLeftTag;
	private bool blockedRight= false;
	private bool blockedLeft= false;
	
	void Start(){
		this.width = GetComponent<Renderer>().bounds.size.x;
	}
	
	public void onDrag (float vertical, float horizontal){
		if((horizontal >= 0 && !blockedRight)
		   ||
		   (horizontal <= 0 && !blockedLeft))
			transform.Translate (horizontal * c,0,0);
	}

	public void onRelease(){}
	
	void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == anchorRightTag)
            blockedRight = true;

        if (coll.gameObject.tag == anchorLeftTag)
            blockedLeft = true;
    }

	void OnCollisionExit2D(Collision2D coll) {
        if (coll.gameObject.tag == anchorRightTag)
            blockedRight = false;

        if (coll.gameObject.tag == anchorLeftTag)
            blockedLeft = false;

    }
	
}