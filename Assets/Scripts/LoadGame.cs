using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {
	Button play;
	// Use this for initialization
	void Start () {
		play = this.GetComponent<Button> ();
		play.onClick.AddListener (() => MainLevel());
	}
	
	// Update is called once per frame
	void Update () {
		 
	}
	void MainLevel(){
		SceneManager.LoadScene ("GameScene");
	}
}
