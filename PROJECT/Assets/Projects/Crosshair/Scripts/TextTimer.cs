using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{
	public float lifeTime = 2f;
	void Update ()
	{
		if (this.GetComponent<Text> ().isActiveAndEnabled)
			Destroy (gameObject, lifeTime);
	}

}
