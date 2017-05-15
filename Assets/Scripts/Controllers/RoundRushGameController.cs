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

	public void ShowRoundRushGameScreen(RoundRushGameReferences roundRushGameReference)
	{
		ShouldAllowRoundMovement = true;
		roundRushGameRef = roundRushGameReference;
		roundRushGameRef.gameObject.SetActive (true);
		ballRoutine = StartCoroutine (SpawnBalls ());
	}

	public void HideRoundRushGameScreen()
	{
		roundRushGameRef.gameObject.SetActive (false);
	}

	IEnumerator SpawnBalls()
	{
		yield return new WaitForSeconds (1.0f);
		while (true) {
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
}
