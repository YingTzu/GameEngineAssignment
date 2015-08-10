using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour 
{
	private Transform player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.position;
		playerPos.z = transform.position.z;
		transform.position = playerPos;
	}
}