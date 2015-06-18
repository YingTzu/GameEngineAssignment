using UnityEngine;
using System.Collections;

public class createWalls : MonoBehaviour {
	public GameObject horWalls;
	public GameObject verWalls;
	public float gap = 0.1f;

	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
		for (int x = 0; x < 15; x++) {
			Instantiate(horWalls, new Vector3(x+x*gap - 1, 16, 0), Quaternion.identity);
		}

		for (int x = 0; x < 15; x++) {
			Instantiate(horWalls, new Vector3(x+x*gap -1, -16, 0), Quaternion.identity);
		}

		for (int y = 0; y < 25; y++) {
			Instantiate(verWalls, new Vector3(-9, y+y*gap -13.5f, 0), Quaternion.identity);
		}
		for (int y = 0; y < 25; y++) {
			Instantiate(verWalls, new Vector3(23, y+y*gap -13.5f, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
