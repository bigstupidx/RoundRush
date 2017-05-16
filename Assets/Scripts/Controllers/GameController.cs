using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

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
		RoundRushGameController.Instance.ShowRoundRushGameScreen (gameRef.roundRushGameRef);
	}

	public void OpenGameOverScreen ()
	{
		RoundRushGameController.Instance.HideRoundRushGameScreen ();
		GameOverScreenController.Instance.ShowGameOverScreen (gameRef.gameOverScreenRef);
	}

	public void OpenRoundRushGameScreen ()
	{
		GameOverScreenController.Instance.HideGameOverScreen ();
		RoundRushGameController.Instance.ShowRoundRushGameScreen (gameRef.roundRushGameRef);
	}
}
