using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class ButtonScript : MonoBehaviour 
{
	public bool resetOptionAppear;
	public bool yesAppear;
	public bool noAppear;

	public Image YesButton;
	public Image NoButton;
	public Image ResetOptions;

	private GameObject popOut;

	public string file2 = "Assets/Save2.txt";
	public string file3 = "Assets/Save3.txt";

	void Start () {
		popOut = GameObject.Find ("PopOut");

		resetOptionAppear = false;

		if (Application.loadedLevelName == "Option") {
			ResetOptions.enabled = false;
			YesButton.enabled = false;
			NoButton.enabled = false;
		}
	}

	void Update () {
	}

	public void startGame()
	{
		Application.LoadLevel("LevelSelect");
	}

	public void optionGame()
	{
		Application.LoadLevel("Option");
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

	public void backToMenu()
	{
		Application.LoadLevel("Menu");
	}

	public void tutorial()
	{
		Application.LoadLevel("Tutorial");
	}

	public void ResetUserData()
	{
		if (resetOptionAppear == false) 
		{
			ResetOptions.enabled = true;
			YesButton.enabled = true;
			NoButton.enabled = true;
			resetOptionAppear = true;
		} 
	}

	public void yesButton()
	{
		ResetOptions.enabled = false;
		YesButton.enabled = false;
		NoButton.enabled = false;
		
		resetOptionAppear = false;

		PlayerPrefs.SetInt ("HighScore1", 0);
		PlayerPrefs.SetInt ("HighScore2", 0);
		PlayerPrefs.SetInt ("HighScore3", 0);

		var sr = File.CreateText(file2);
		sr.WriteLine ("0");
		sr.Close();

		var sr2 = File.CreateText(file3);
		sr2.WriteLine ("0");
		sr2.Close();
	}

	public void noButton()
	{
		ResetOptions.enabled = false;
		YesButton.enabled = false;
		NoButton.enabled = false;

		resetOptionAppear = false;
	}
}
