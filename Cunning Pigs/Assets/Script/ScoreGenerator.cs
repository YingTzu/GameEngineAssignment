using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour {

	public static int Score;

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();	
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;
		text.text = "" + Score;
	}

	public static void AddScore (int ScoreAdd)
	{
		Score += ScoreAdd;
	}

	public static void Reset()
	{
		Score = 0;
	}
}