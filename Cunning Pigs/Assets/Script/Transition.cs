using UnityEngine;
using System.IO;
using System.Collections;

public class Transition : MonoBehaviour {

	public string file = "Assets/Save1.txt";
	public string file2 = "Assets/Save2.txt";
	public string file3 = "Assets/Save3.txt";

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
				var sr = File.CreateText(file);
				sr.WriteLine ("1");
				sr.Close();

				Application.LoadLevel("level 2");
			}
			else if(Application.loadedLevelName == "Level 2")
			{
				var sr = File.CreateText(file2);
				sr.WriteLine ("1");
				sr.Close();
				Application.LoadLevel("level 3");
			}
			else if(Application.loadedLevelName == "Level 3")
			{
				var sr = File.CreateText(file3);
				sr.WriteLine ("1");
				sr.Close();

				Application.LoadLevel("GameWin");

			}


				


		}
			//Application.LoadLevel("level 2");
	}
}
