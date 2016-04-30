using UnityEngine;

/**
 * Touch screen control component
 */
public class ScreenDragListener : MonoBehaviour
{
	private Vector2 touchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.
	private Component[] onDragListeners;

	// Use this for initialization
	void Start ()
	{
		onDragListeners = (Component[])GetComponentsInChildren(typeof(OnDragListener));
	}
	
	// Update is called once per frame
	void Update ()
	{
		int horiz = 0;     //Used to store the horizontal move direction.
		int vert = 0;       //Used to store the vertical move direction.
		if (Input.touchCount > 0) {
			//Store the first touch detected.
			Touch myTouch = Input.touches[0];
			
			//Check if the phase of that touch equals Began
			if (myTouch.phase == TouchPhase.Began) {
				//If so, set touchOrigin to the position of that touch
				touchOrigin = myTouch.position;
			}

			//If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
			else if (myTouch.phase == TouchPhase.Moved && touchOrigin.x >= 0) {
				//Set touchEnd to equal the position of this touch
				Vector2 touchEnd = myTouch.position;
				
				//Calculate the difference between the beginning and end of the touch on the x axis.
				float x = touchEnd.x - touchOrigin.x;
				
				//Calculate the difference between the beginning and end of the touch on the y axis.
				float y = touchEnd.y - touchOrigin.y;
				
				//Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
				touchOrigin.x = -1;
				
				//Check if the difference along the x axis is greater than the difference along the y axis.
				if (Mathf.Abs (x) > Mathf.Abs (y))
					//If x is greater than zero, set horizontal to 1, otherwise set it to -1
					horiz = x > 0 ? 1 : -1;
				else
					//If y is greater than zero, set horizontal to 1, otherwise set it to -1
					vert = y > 0 ? 1 : -1;
				
				if (horiz != 0 || vert != 0) {
					
					foreach(OnDragListener onDragListener in onDragListeners){
						onDragListener.onDrag (vert, horiz);
					}
				}
				touchOrigin = myTouch.position;
			}
		} else {
			foreach(OnDragListener onDragListener in onDragListeners){
				onDragListener.onRelease();
			}
			
		}
	}

	public interface OnDragListener
	{
		void onDrag (float vertical, float horizontal);
		void onRelease();
	}
	
	
}