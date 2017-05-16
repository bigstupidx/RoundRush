using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenController : Singleton<GameOverScreenController> {

	GameOverScreenReferences gameOverScreenRef;

	public void ShowGameOverScreen(GameOverScreenReferences gameOverScreenReferences)
	{
		gameOverScreenRef = gameOverScreenReferences;
		gameOverScreenRef.gameObject.SetActive (true);
	}

	public void HideGameOverScreen ()
	{
		gameOverScreenRef.gameObject.SetActive (false);
	}
}
