using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 6.0f * 180 * Time.deltaTime, 0);
	
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name.Contains ("Target")) {
			Destroy (col.gameObject);

		}

	}
}
