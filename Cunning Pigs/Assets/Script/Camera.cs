using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour 
{
	private Transform player;
	// Use this for initialization
	void Start () {
		this.GetComponent<UnityEngine.Camera>().aspect = 1280f / 800f;
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.position;
		playerPos.z = transform.position.z;
		transform.position = playerPos;
	}
}