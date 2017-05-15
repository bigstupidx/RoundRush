using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundBallMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("In start");
	}
	
	// Update is called once per frame
	void Update () {

//		Debug.Log ("In Update");

		if (RoundRushGameController.Instance.ShouldAllowRoundMovement) {

			if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown (0))) {

//				Vector3 worldPoint = Vector3.zero;
//				#if UNITY_EDITOR
//				worldPoint=Camera.main.ScreenToWorldPoint (Input.mousePosition);
//				//for touch device
//				#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
//				worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
//				#endif
//				if(gameObject.GetComponent<Collider2D>().OverlapPoint(worldPoint)){
					Vector3 oldRotation = transform.rotation.eulerAngles;
					float tiltAroundZ = oldRotation.z + 90.0f;
					transform.rotation = Quaternion.Euler(0, 0, tiltAroundZ);
//		       }
			} else if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp (0))) {
				Debug.Log ("touch ended");
			}
		
		}
 	}

//	void OnCollisionEnter2D(Collision2D collider)
//	{
//		if (collider.gameObject.tag == "Red" || collider.gameObject.tag == "Yellow" || collider.gameObject.tag == "Green" || collider.gameObject.tag == "Blue") {
//
//			Destroy (collider.gameObject);
//		}
//	}
}
