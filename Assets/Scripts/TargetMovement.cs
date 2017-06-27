using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class TargetMovement : MonoBehaviour {
	
	public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.position =  new Vector3 (this.transform.position.x, 0, this.transform.position.z - (speed * Time.deltaTime));
		//Debug.Log (this.transform.position.z);
		if (this.transform.position.z <= 40.0f) {
			Destroy (this.gameObject);
			SceneManager.LoadScene ("GameOver");
			CanvasScript.t1 = "Game Over!";
		}
	}

}
