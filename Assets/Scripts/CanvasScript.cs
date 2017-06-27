using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {
	public static Text t;
	public static string t1;
	// Use this for initialization
	void Start () {
		t = GameObject.Find ("MainScreenCanvas/GameOverText").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		t.text = t1;			
	}
}
