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
		Application.LoadLevel("LevelSelect");
	}

	public void exitGame()
	{
		Application.Quit ();
	}

	public void selectLevel1()
	{
		Application.LoadLevel("Level 1");
	}

	public void selectLevel2()
	{
		Application.LoadLevel("Level 2");
	}

	public void selectLevel3()
	{
		Application.LoadLevel("Level 3");
	}
}
