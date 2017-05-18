using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenController : Singleton<GameOverScreenController> {

	GameOverScreenReferences gameOverScreenRef;

	public void ShowGameOverScreen(GameOverScreenReferences gameOverScreenReferences)
	{
		gameOverScreenRef = gameOverScreenReferences;
		gameOverScreenRef.playerScoreLabel.gameObject.SetActive (true);
		gameOverScreenRef.bestScore.gameObject.SetActive (true);
		gameOverScreenRef.gameCountLabel.gameObject.SetActive (true);
		UpdateScore ();
		UpdateBestScore ();
		UpdateGameCount ();
		gameOverScreenRef.gameObject.SetActive (true);
	}

	public void HideGameOverScreen ()
	{
		gameOverScreenRef.gameObject.SetActive (false);
	}

	public void UpdateScore ()
	{
		gameOverScreenRef.playerScoreLabel.text = " " + GameModel.Instance.Score.ToString();
	}

	public void UpdateBestScore()
	{
		gameOverScreenRef.bestScore.text = " " + GameModel.Instance.BestScore.ToString (); 
	}

	public void UpdateGameCount ()
	{
		gameOverScreenRef.gameCountLabel.text = "Game Played Count: " + GameModel.Instance.GameCount.ToString ();
	}
}
 