using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShield : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.z > 145) {
			Destroy (this.gameObject);
		}
	}
}
