using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ChakramSpawnPrefab : MonoBehaviour {
	Object g;
	GameObject g1;
	public Slider s;
	public GameObject g2;
	void Start () {
		g = AssetDatabase.LoadAssetAtPath ("Assets/Cartoon_Weapon_Pack/Prefab/Shield_03.prefab", typeof(GameObject));
			g1 = Instantiate (g, new Vector3 (250, 5, 5),Quaternion.Euler(180,0,0))as GameObject;

	}
	
	// Update is called once per frame
	/*void Update () {
		if (Input.GetKeyUp ("space")) {
			float a = s.value;

			g1.GetComponent<Rigidbody> ().AddForce (new Vector3 (a*250, 0, 8000));

		}
		if (g1.transform.position.z > 15.0f) {
			g1 = Instantiate (g, new Vector3 (250, 5, 5),Quaternion.Euler(180,0,0))as GameObject;
		}
	}*/
	void Update(){
		if (Input.GetKeyUp ("space")) {
			float y = g2.transform.rotation.eulerAngles.y;
			if (y > 300) {
			
				y = y-360;
			}
			g1.GetComponent<Rigidbody> ().AddForce (new Vector3 (y*250, 0, 8000));
		}
		if (g1.transform.position.z > 15.0f) {
			g1 = Instantiate (g, new Vector3 (250, 5, 5),Quaternion.Euler(180,0,0))as GameObject;
		}

	}


}
