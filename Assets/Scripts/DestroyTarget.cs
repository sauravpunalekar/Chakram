using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyTarget : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col)
	{
		Destroy (this.gameObject);
		Destroy (col.gameObject);
		ScoreCount.score++;
		ScoreDisplay.isCollision = true;
		ScoreCount.scoretext.text = "Targets Killed : "+ScoreCount.score+"/"+ScoreCount.reqScore;
	}
}
