using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameModel: Singleton <GameModel>
{
	private int bestScore;

	public int Score
	{
		get;
		set;
	}

	public int BestScore {
		get{ return bestScore;}
		set{bestScore = value;}
	}

	public int GameCount {
		get;
		set;
	}

	public int AdGameCount {
		get;
		set;
	}
	public void SetUpGameVariables()
	{
		this.Score = 0;
		if (PlayerPrefs.HasKey ("BestScore")) {
			bestScore = PlayerPrefs.GetInt ("BestScore");
		}  else {
			bestScore = 0;
		}
		if (PlayerPrefs.HasKey ("GameCount")) {
			this.GameCount = PlayerPrefs.GetInt ("GameCount");
		}  else {
			this.GameCount = 0;
		}
	}
}
