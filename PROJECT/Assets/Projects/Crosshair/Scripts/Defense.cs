using UnityEngine;
using System.Collections;

public class Defense : MonoBehaviour
{
	public Color color;
	// Use this for initialization
	void Start ()
	{
		if (color == null)
			color = new Color (0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter (Collision other)
	{
		color.r += 0.1f;
		Destroy (other.gameObject);
		foreach (Renderer r in GetComponentsInChildren<Renderer>()) {
			r.material.color = color;
		}

	}
}
