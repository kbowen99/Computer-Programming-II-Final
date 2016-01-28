using UnityEngine;
using System.Collections;

public class Flight : MonoBehaviour {

	//Movement Variables, Allows for multiple keycodes
	bool LeftPress = false;
	bool RightPress = false;
	bool BombPress = false;
	float MoveSpeed = 4.0f; //Floats take up more space in RAM, but allow faster calculations

	//this is da Bomb!
	public GameObject BombPrefab;

	// Use this for initialization
	void Start () {	}

	// Update is called once per frame
	void Update () {
		//check for input (Booleans allow for easy expandability)
		LeftPress = (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow));
		RightPress = (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow));
		BombPress = (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.Space));

		//Left/Right Movement
		if (LeftPress && transform.position.x > -9.0f) {
			transform.Translate (Vector3.left * Time.deltaTime * MoveSpeed);
		}
		if (RightPress && transform.position.x < 9.0f) {
			transform.Translate (Vector3.right * Time.deltaTime * MoveSpeed);
		} 
		//bombing code
		if (BombPress && GameObject.FindWithTag("Bomb") == null) {
			Instantiate(BombPrefab, new Vector3(transform.position.x ,(transform.position.y - 1.0f)), Quaternion.identity); //Spawn a bomb unlike any other
		}
	}
}
