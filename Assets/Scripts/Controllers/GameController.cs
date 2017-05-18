using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using ChartboostSDK;

public class GameController : Singleton<GameController> {

	GameReferences gameRef;
	GameObject gameContextObject;

	public bool IsUIOpened {
		get;
		set;
	}

	//Loads the game
	public void LoadGame(GameObject gameObject)
	{
		gameContextObject = gameObject;
		IsUIOpened = false;
		gameRef = gameContextObject.GetComponent<GameReferences> ();
		GameStartScreenController.Instance.ShowGameStartScreen (gameRef.gameStartScreenRef);
	}

	public void PlayGame ()
	{
		if (GameModel.Instance.Score > GameModel.Instance.BestScore) {
			GameModel.Instance.BestScore = GameModel.Instance.Score;
			PlayerPrefs.SetInt ("BestScore", GameModel.Instance.BestScore);
		}
		GameStartScreenController.Instance.HideGameStartScreen ();
		RoundRushGameController.Instance.ShowRoundRushGameScreen (gameRef.roundRushGameRef);
	}

	public void OpenGameOverScreen ()
	{
		PlayerPrefs.SetInt ("GameCount", GameModel.Instance.GameCount);
		RoundRushGameController.Instance.HideRoundRushGameScreen ();
		if (GameModel.Instance.GameCount % 3 == 0) {
			Debug.Log ("Show Ad");
			Chartboost.showInterstitial(CBLocation.HomeScreen);
		}
		GameOverScreenController.Instance.ShowGameOverScreen (gameRef.gameOverScreenRef);
	}

	public void OpenRoundRushGameScreen ()
	{
		if (GameModel.Instance.Score > GameModel.Instance.BestScore) {
			GameModel.Instance.BestScore = GameModel.Instance.Score;
			PlayerPrefs.SetInt ("BestScore", GameModel.Instance.BestScore);
		}
		GameOverScreenController.Instance.HideGameOverScreen ();
		RoundRushGameController.Instance.ShowRoundRushGameScreen (gameRef.roundRushGameRef);
	}
}
