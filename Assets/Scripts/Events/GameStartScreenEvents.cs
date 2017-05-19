using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScreenEvents : MonoBehaviour {

	public void PlayButtonPressed()
	{
		GameController.Instance.PlayGame ();
	}

	public void SoundButtonPressed()
	{
		GameController.Instance.SoundOnOff ();
	}

	public void ShareButtonPressed()
	{
	}

	public void LeaderBoardButtonPressed ()
	{
	}
}
