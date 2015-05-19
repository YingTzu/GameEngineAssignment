using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour 
{
	private Transform player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
//		Vector2 playerPos = player.position;
//		transform.position = playerPos;
	}
}
