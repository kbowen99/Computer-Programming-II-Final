using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class HighScorer : MonoBehaviour {

	public float HighScore = 0.0f;
	Text DoMagicalHighScore;

	// Use this for initialization
	void Start () {
		DoMagicalHighScore = GetComponent<Text> ();
		LoadScores ();
		if (GetCurrentHigh () < 0) {
			SaveScores(1000);
			LoadScores();
		}
	}
	
	// Update is called once per frame
	void Update () {
		DoMagicalHighScore.text = HighScore.ToString () + " Seconds";
	}

	public void LoadScores() {
		try {
			HighScore = float.Parse(File.ReadAllText (Application.dataPath + "/SCORE.KurtScore"));
		} catch {
			Debug.Log("High Score failed to load, creating new savefile now");
			File.WriteAllText (Application.dataPath + "/SCORE.KurtScore", HighScore.ToString());
		}
	}

	public void SaveScores(float score) {
		try{
			File.WriteAllText (Application.dataPath + "/SCORE.KurtScore", score.ToString());
		} catch {
			Debug.Log("File Creation Failed, No Highscores were saved");
		}
	}

	public float GetCurrentHigh(){
		LoadScores ();
		return HighScore;
	}
}
