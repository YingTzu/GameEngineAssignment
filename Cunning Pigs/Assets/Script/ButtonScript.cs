using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
			{
				Application.LoadLevel("Level 1");

			}
		}

	
	}
}
