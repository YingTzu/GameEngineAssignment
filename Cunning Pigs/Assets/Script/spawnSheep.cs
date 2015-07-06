using UnityEngine;
using System.Collections;

public class spawnSheep : MonoBehaviour {
	public GameObject sheep;
	public int numberOfSheep = 7;
	public int min = 1;
	public int max = 62;

	void Start () {
		PlaceSheep ();
	}

	void Update () {
	}

	void PlaceSheep()
	{
		for (int i = 0; i < numberOfSheep; i++) {
			Instantiate(sheep, GeneratedPosition(), Quaternion.identity);
		}
	}

	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = Random.Range(min,max);
		y = Random.Range(min,max);
		z = Random.Range(min,max);
		return new Vector3(x,y,z);
	}
}
