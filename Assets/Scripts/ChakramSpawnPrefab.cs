using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChakramSpawnPrefab : MonoBehaviour {
	Object g;
	GameObject g1;
	void Start () {
		g = AssetDatabase.LoadAssetAtPath ("Assets/Cartoon_Weapon_Pack/Prefab/Shield_03.prefab", typeof(GameObject));
			g1 = Instantiate (g, new Vector3 (250, 5, 5),Quaternion.Euler(180,0,0))as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			g1.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 8000));

		}
		if (g1.transform.position.z > 15.0f) {
			g1 = Instantiate (g, new Vector3 (250, 5, 5),Quaternion.Euler(180,0,0))as GameObject;
		}
	}


}
