using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
	public static int score;
	public static int reqScore;
	public static int speed;
	public static Text scoretext;
	// Use this for initialization
	void Start () {
		score = 3;
		reqScore = 3;
		scoretext = GameObject.Find ("Canvas/Score").GetComponent<Text>() ;
		scoretext.text = "Targets Killed : "+ScoreCount.score+"/"+ScoreCount.reqScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
