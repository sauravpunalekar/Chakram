using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	public static Text myScore;
	public static bool isCollision = false;
	// Use this for initialization
	void Start () {
		myScore = GameObject.Find ("Canvas/ScoreDisplay").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isCollision) {
		} else {
			if (myScore.fontSize < 300) {
				myScore.text = ScoreCount.score.ToString ();
				myScore.fontSize += 11;
			} else {
				isCollision = false;
				myScore.text = "";
				myScore.fontSize = 14;
			}
		}
			
	}
}
