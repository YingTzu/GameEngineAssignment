using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {

void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
	}
}
