using UnityEngine;
using System.Collections;

public class BombDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//once bomb falls too low, destroy it
		if (transform.position.y < -4.0f) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		Destroy (gameObject);
		//destroy bomb on collision with tanks
	}
}
