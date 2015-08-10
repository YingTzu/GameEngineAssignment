using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour {

	public static ScoreGenerator SG;
	public static int Score;
	int highScore;

	public Text score;
	public Text highScoreText;

	// Use this for initialization
	void Start () {
		SG = this;
		Score = 0;
		if(Application.loadedLevelName == "Level 1")
			highScore = PlayerPrefs.GetInt("HighScore1", highScore);
		else if(Application.loadedLevelName == "Level 2")
			highScore = PlayerPrefs.GetInt("HighScore2", highScore);
		else if(Application.loadedLevelName == "Level 3")
			highScore = PlayerPrefs.GetInt("HighScore3", highScore);
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;

		score.text = "Score: " + Score;
		highScoreText.text = " High Score: " + highScore;

		CheckHighScore ();
	}

	public void CheckHighScore()
	{
		if (Score > highScore) 
		{
			if(Application.loadedLevelName == "Level 1")
			{
				PlayerPrefs.SetInt("HighScore1", Score);
				highScore = PlayerPrefs.GetInt("HighScore1", highScore);
			}
			else if(Application.loadedLevelName == "Level 2")
			{
				PlayerPrefs.SetInt("HighScore2", Score);
				highScore = PlayerPrefs.GetInt("HighScore2", highScore);
			}
			else if(Application.loadedLevelName == "Level 3")
			{
				PlayerPrefs.SetInt("HighScore3", Score);
				highScore = PlayerPrefs.GetInt("HighScore3", highScore);
			}

		}
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