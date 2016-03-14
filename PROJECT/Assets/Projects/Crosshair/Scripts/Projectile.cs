using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

	float lifeTime = 1f;
	void Awake ()
	{
		Destroy (gameObject, lifeTime);
	}
	

}
