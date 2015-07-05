using UnityEngine;
using System.Collections;

public class GameWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{
		GUI.contentColor = Color.yellow;
		if (GUI.Button (new Rect(Screen.width / 2 - 50 , Screen.height / 2 , 100, 40), "Home"))
		{
			Application.LoadLevel (0);
		}
		if (GUI.Button (new Rect(Screen.width / 2 - 50 , Screen.height / 2 + 50 , 100, 40), "Replay"))
		{
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 100, 100, 40), "Exit"))
		{
			Application.Quit();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
