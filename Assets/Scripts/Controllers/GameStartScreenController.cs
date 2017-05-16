using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScreenController : Singleton<GameStartScreenController> {

	GameStartScreenReferences gameStartScreenRef;

	public void ShowGameStartScreen(GameStartScreenReferences gameStartScreenReferences)
	{
		gameStartScreenRef = gameStartScreenReferences;
		gameStartScreenRef.gameObject.SetActive (true);
	}

	public void HideGameStartScreen ()
	{
		gameStartScreenRef.gameObject.SetActive (false);
	}

}
