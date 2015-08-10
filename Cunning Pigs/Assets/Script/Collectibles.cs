using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {

	public int ScoreAdd;
	private GameObject audio;

	void Start()
	{
		audio = GameObject.Find ("SFX");
	}

void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			ScoreGenerator.AddScore (ScoreAdd);
			Destroy (this.gameObject);

			audio.GetComponent<AudioScript>().playOnceCustom(0);
		}
	}
}
