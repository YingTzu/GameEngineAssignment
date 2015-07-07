using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		{
			Collider[]hitCollides =Physics.OverlapSphere(this.transform.position,0);
			for(int i = 0; i < hitCollides.Length; i++)
			{
			if (hitCollides[i].gameObject.tag =="Player")
			

					Application.LoadLevel("level 2");
			}

		}

	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.gameObject.tag =="Player")
			Application.LoadLevel("level 2");
	}
}
