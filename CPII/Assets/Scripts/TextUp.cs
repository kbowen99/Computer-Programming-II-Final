using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextUp : MonoBehaviour {

	public string UpdateTxt;
	bool CanWin = false;

	Text DoMagical;	
	GameObject Tank;
	HighScorer SaveScore;
	// Use this for initialization
	
	void Start () {
		//find the magic
		DoMagical = GetComponent<Text> ();
		CanWin = true;
		SaveScore = GameObject.FindObjectOfType (typeof(HighScorer)) as HighScorer;
	}
	
	// Update is called once per frame
	void Update () {
		if (CanWin) {
			try {
				Tank = GameObject.FindGameObjectWithTag ("Tank");
				Debug.Log (Tank.ToString ());
				UpdateTxt = System.Math.Round ((Time.time), 2).ToString ();
				DoMagical.text = UpdateTxt;
			} catch {
				float WinTime = (float)System.Math.Round ((Time.time), 2);

				if (WinTime < SaveScore.GetCurrentHigh() || SaveScore.GetCurrentHigh() == 0.0f){
					string Winner = "You won in " + WinTime.ToString () + " seconds try to beat your New high score!";
					DoMagical.text = Winner;
					SaveScore.SaveScores(WinTime);
					SaveScore.LoadScores();
				} else {
					string Winner = "You won in " + WinTime.ToString () + " seconds try to beat your high score!";
					DoMagical.text = Winner;
				}
				CanWin = false;
			}
		}
	}
}
