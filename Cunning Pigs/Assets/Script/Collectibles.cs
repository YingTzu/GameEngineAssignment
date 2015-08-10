using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {

	public int ScoreAdd;

void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			ScoreGenerator.AddScore (ScoreAdd);
			Destroy (this.gameObject);
		}
	}
}
