using UnityEngine;
using System.Collections;

public class DieOnCollide : MonoBehaviour
{
	public GameObject layoutGameEnd;
	public string enemyTag;
	public string friendTag;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == enemyTag) {
			Destroy(gameObject);
			layoutGameEnd.SetActive(true);
		}
		if (collision.gameObject.tag == friendTag) {
			Destroy(collision.gameObject);
			ScoreManager.getInstance().pointUp();
		}
		
	}
}