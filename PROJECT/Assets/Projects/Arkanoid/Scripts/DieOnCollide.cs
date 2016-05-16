using UnityEngine;
using System.Collections;

public class DieOnCollide : MonoBehaviour
{

	public string enemyTag;
	public string targetTag;
	private int numEnemies;
	void Start(){
		numEnemies =  GameObject.FindGameObjectsWithTag(targetTag).Length;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == enemyTag) {
			Destroy(gameObject);
            GlobalGameManager.getInstance().loadArkanoidWaterPipes();
		}
		if (collision.gameObject.tag == targetTag) {
			collision.gameObject.GetComponent<Animation>().Play();
			ScoreManager.getInstance().incr(100);
			numEnemies--;
			if(numEnemies == 0){
				GlobalGameManager.getInstance ().loadArkanoidWaterPipes();
			}
		}
		
	}
}