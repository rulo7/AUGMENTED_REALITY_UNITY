using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour
{

	
	float lifeTime = 4f;
	void Awake ()
	{
		Destroy (gameObject, lifeTime);
	}

	void Update ()
	{

	}
}
