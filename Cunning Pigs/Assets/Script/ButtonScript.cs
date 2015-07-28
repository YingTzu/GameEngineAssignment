using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour 
{
	void Start () {
	}

	void Update () {
	}

	public void startGame()
	{
		Application.LoadLevel("Level 1");
	}

	public void exitGame()
	{
		Application.Quit ();
	}
}
