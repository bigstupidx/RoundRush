using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScreenEvents : MonoBehaviour {

	public void PlayButtonPressed()
	{
		GameController.Instance.PlayGame ();
	}
}
