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
	}

	public void ShareButtonPressed()
	{
	}

	public void LeaderBoardButtonPressed ()
	{
	}
}
