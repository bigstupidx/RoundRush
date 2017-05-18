using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundRushGameController : Singleton<RoundRushGameController> {

	RoundRushGameReferences roundRushGameRef;
	Coroutine ballRoutine = null;

	public bool ShouldAllowRoundMovement {
		get;
		set;
	}

	public bool IsGameOver {
		get;
		set;
	}

	public void ShowRoundRushGameScreen(RoundRushGameReferences roundRushGameReference)
	{
		ShouldAllowRoundMovement = true;
		IsGameOver = false;
		roundRushGameRef = roundRushGameReference;
		roundRushGameRef.roundColouredBall.gameObject.SetActive (true);
		roundRushGameRef.playerScoreLabel.gameObject.SetActive (true);
		roundRushGameRef.bestScore.gameObject.SetActive (true);
		roundRushGameRef.gameObject.SetActive (true);
		GameModel.Instance.SetUpGameVariables ();
		UpdateScore ();
		UpdateBestScore ();
		GameModel.Instance.GameCount++;
		ballRoutine = StartCoroutine (SpawnBalls ());
	}

	public void HideRoundRushGameScreen()
	{
		IsGameOver = true;
		roundRushGameRef.roundColouredBall.gameObject.SetActive (false);
		roundRushGameRef.bestScore.gameObject.SetActive (false);
		roundRushGameRef.gameObject.SetActive (false);
		if(ballRoutine != null)
			StopCoroutine (ballRoutine);
	}

	IEnumerator SpawnBalls()
	{
		yield return new WaitForSeconds (1.0f);
		while (!IsGameOver) {
			GameObject ball = roundRushGameRef.balls;
//			float[] x_values = { -2.3f,-2.0f,-1.5f,-1.0f,-0.5f,0.0f,0.5f,1.0f,1.5f,2.0f, 2.3f };
			float x_value = 0.0f;
			Vector3 spawnPosition = new Vector3(
				x_value,
				5.5f,
				0.0f
			);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(ball, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(Random.Range(2.0f, 2.5f));
		}
	}

	public void UpdateScore ()
	{
		roundRushGameRef.playerScoreLabel.text = "Score: " + GameModel.Instance.Score.ToString();
	}

	public void UpdateBestScore()
	{
		roundRushGameRef.bestScore.text = "BEST: " + GameModel.Instance.BestScore.ToString (); 
	}
}
