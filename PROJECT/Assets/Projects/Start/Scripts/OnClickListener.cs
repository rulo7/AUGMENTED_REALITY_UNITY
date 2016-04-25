using UnityEngine;
using System.Collections;

public class OnClickListener : MonoBehaviour {

	public void OnClick () {
		GlobalGameManajer.geInstance ().loadArkanoid ();
	}
}
