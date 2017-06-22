using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		}
	}

}
