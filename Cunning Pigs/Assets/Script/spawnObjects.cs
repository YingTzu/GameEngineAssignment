using UnityEngine;
using System.Collections;

public class spawnObjects : MonoBehaviour {
	public GameObject sheep;
	public GameObject redRidingHood;
	public GameObject Grandma;
	public int numberOfSheep = 7;
	public int minX, maxX, minY, maxY;

	void Start () {
		PlaceObjects ();
	}

	void Update () {
	}

	void PlaceObjects()
	{
		for (int i = 0; i < numberOfSheep; i++) {
			Instantiate(sheep, GeneratedPosition(), Quaternion.identity);
		}

		Instantiate(redRidingHood, GeneratedPosition(), Quaternion.identity);
		Instantiate(Grandma, GeneratedPosition(), Quaternion.identity);
	}

	Vector3 GeneratedPosition()
	{
		int x,y;
		x = Random.Range(minX,maxX);
		y = Random.Range(minY,maxY);
		return new Vector3(x,y,0);
	}
}
