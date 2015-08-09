using UnityEngine;
using System.Collections;

public class destroyonCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.gameObject.tag == "Player")
			Destroy (this.gameObject);
	}
}
