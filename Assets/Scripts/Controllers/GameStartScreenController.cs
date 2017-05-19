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

	public void ChangeSound ()
	{
		if (GameModel.Instance.IsMusicOn) {
			GameModel.Instance.IsMusicOn = false;
			gameStartScreenRef.soundButton.image.sprite = Resources.Load<Sprite> ("soundOffIcon");
		} else {
			GameModel.Instance.IsMusicOn = true;
			gameStartScreenRef.soundButton.image.sprite = Resources.Load<Sprite> ("soundOnIcon");
		}
	}

}
