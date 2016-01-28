using UnityEngine;
using System.Collections;
public class Tank : MonoBehaviour {

	void OnCollisionEnter2D () {
		Destroy(gameObject); //it really is that easy, only 7 lines
	}
}