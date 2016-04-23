using UnityEngine;
using System.Collections;

public class DieOnCollide : MonoBehaviour
{

	public string enemyTag;
	public string targetTag;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == enemyTag) {
			Destroy(gameObject);
		}
		if (collision.gameObject.tag == targetTag) {
			collision.gameObject.GetComponent<Animation>().Play();
			ScoreManager.getInstance().pointUp();
		}
		
	}
}