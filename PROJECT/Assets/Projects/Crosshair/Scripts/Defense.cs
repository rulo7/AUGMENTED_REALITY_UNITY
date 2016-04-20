using UnityEngine;
using System.Collections;

public class Defense : MonoBehaviour
{
	public Color colorStart; //= new Color32 (105, 168, 255, 255);
	public Color colorEnd = Color.red;
	public Color aux;
	public float inter = 0.1f;
	
	// Use this for initialization
	void Start ()
	{
		foreach (Renderer r in GetComponentsInChildren<Renderer>()) {
			r.material.color = colorStart;
		}
	}

	void OnCollisionEnter (Collision other)
	{
		Destroy (other.gameObject);
		aux = Color.Lerp (colorStart, colorEnd, inter);
		foreach (Renderer r in GetComponentsInChildren<Renderer>()) {
			r.material.color = aux;
		}
		inter += 0.1f;
	}
}
