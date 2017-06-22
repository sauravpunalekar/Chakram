using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChakramMove : MonoBehaviour {
	public GameObject g;

	Rigidbody r;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp ("enter")) {
			r = g.GetComponent<Rigidbody> ();
			Vector3 pos = new Vector3 (0,0,8000);
			r.AddForce (pos);

		}

	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name.Contains ("Target")) {
			Destroy (col.gameObject);
				
		}
	}
}
