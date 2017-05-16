using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	private enum BallTypes {
		Yellow = 0,
		Green = 1, 
		Blue = 2,
		Red = 3
	}

	private BallTypes ballType;
	// Use this for initialization
	void Start () {
		Debug.Log ("In box start");
//		ballImage = gameObject.GetComponent (SpriteRenderer);
		int[] ballValues = { 0, 1, 2, 3 };
		int selectedBall = ballValues [Random.Range (0, ballValues.Length)];
		if (selectedBall == 0) {
			
			ballType = BallTypes.Yellow;
			Debug.Log ("In yellow");
			GetComponent<SpriteRenderer>().color = Color.yellow;
			gameObject.tag = "Yellow";
//			ballImage.color = Color.green;
//				new Color (248f,251f,30f,255f);
		} 
		else if (selectedBall == 1) {
			
			ballType = BallTypes.Green;
			Debug.Log ("In green");
//			GetComponent<SpriteRenderer>().color = new Color (97f,184f,81f,255f);
			GetComponent<SpriteRenderer>().color = Color.green;
			gameObject.tag = "Green";
//			ballImage.color = new Color (97f,184f,81f,255f);
		}
		else if (selectedBall == 2) {
			
			ballType = BallTypes.Blue;
			Debug.Log ("In blue");
			GetComponent<SpriteRenderer>().color = Color.cyan;
			gameObject.tag = "Blue";
//			ballImage.color = new Color (8f,195f,255f,255f);
		}
		else if (selectedBall == 3) {
			
			ballType = BallTypes.Red;
			Debug.Log ("In red");
			GetComponent<SpriteRenderer>().color = Color.red;
			gameObject.tag = "Red";
//			ballImage.color = new Color (255f,9f,45f,255f);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Red" || collider.gameObject.tag == "Yellow" || collider.gameObject.tag == "Green" || collider.gameObject.tag == "Blue") {

			Destroy (gameObject);
		}
		if (gameObject.tag == collider.gameObject.tag) {

			Debug.Log (gameObject.tag);
			Debug.Log (collider.gameObject.tag);
			GameModel.Instance.Score++;
			RoundRushGameController.Instance.UpdateScore ();
			Debug.Log ("Same");
		} else {
			Debug.Log ("Game Over");
			GameController.Instance.OpenGameOverScreen ();
		}
	}
}
