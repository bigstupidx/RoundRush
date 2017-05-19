using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenEvents : MonoBehaviour {

	public void ReloadButtonTapped ()
	{
		GameController.Instance.OpenRoundRushGameScreen ();
	}

	public void RateButtonTapped()
	{
		GameController.Instance.RateGame ();
	}
}
