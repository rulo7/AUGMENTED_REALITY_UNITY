using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

	public float lifeTime = 6f;
	void Awake ()
	{
		Destroy (gameObject, lifeTime);
	}
	

}
