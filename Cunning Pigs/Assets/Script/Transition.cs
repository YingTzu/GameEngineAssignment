using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.gameObject.tag == "Player") 
		{
			if(Application.loadedLevelName == "Level 1")
			{
				Application.LoadLevel("level 2");
			}
			else if(Application.loadedLevelName == "Level 2")
			{
				Application.LoadLevel("level 3");
			}
			else if(Application.loadedLevelName == "Level 3")
				Application.LoadLevel("level 1");
		}
			//Application.LoadLevel("level 2");
	}
}
