using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {

	public int ScoreAdd;

void OnTriggerEnter2D(Collider2D collider)
	{
		ScoreGenerator.AddScore (ScoreAdd);

		if (collider.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
	}
}
