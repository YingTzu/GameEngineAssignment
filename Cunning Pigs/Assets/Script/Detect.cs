using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour 
{
	public bool b_Detected = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player")//if detect player in range
			b_Detected = true;
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player")//if player is no longer in detection range
			b_Detected = false;
	}
}
