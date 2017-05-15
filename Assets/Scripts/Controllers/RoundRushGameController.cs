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
	}

	public void HideRoundRushGameScreen()
	{
		roundRushGameRef.gameObject.SetActive (false);
	}

//	IEnumerator SpawnBalls()
//	{
//		yield return new WaitForSeconds (1.0f);
//		while (true) {
//			GameObject ball = roundRushGameRef.ball;
//			float[] x_values = { -5.1900f, 5.1900f };
//			float x_value = x_values [Random.Range(0, x_values.Length)];
//			Vector3 spawnPosition = new Vector3(
//				x_value,
//				-5.5f,
//				0.0f
//			);
//			Quaternion spawnRotation = Quaternion.identity;
//			Instantiate(box, spawnPosition, spawnRotation);
//			yield return new WaitForSeconds(Random.Range(1.0f, 1.5f));
//		}
//	}
}
