using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour {

	float MoveSpeed = 4.0f;
	string DIR = "LEFT";

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (DIR == "LEFT" && transform.position.x > -9.0f) {

//			Vector3 Scale = transform.localScale;
//			Scale.y = 0.3f;
//			transform.localScale = Scale;

		} else {
			DIR = "RIGHT";
		}
		if (DIR == "RIGHT" && transform.position.x < 9.0f) {
			transform.Translate (Vector3.right * Time.deltaTime * MoveSpeed);

//			Vector3 Scale = transform.localScale;
//			Scale.y = -0.3f;
//			transform.localScale = Scale;

		} else {
			DIR = "LEFT";
		}
	}
}
