using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEditor;

public class TargetSpawn : MonoBehaviour {

	Object g;
	GameObject g1;
	float[] xcoord = { 210, 230, 270, 290 };
	int times = 0;
	// Use this for initialization
	void Start () {
		g = AssetDatabase.LoadAssetAtPath ("Assets/Shooting target/Target.prefab", typeof(GameObject));
		g1 = Instantiate (g, new Vector3 (250, 5, 145),Quaternion.Euler(-90,0,-180))as GameObject;
		reshuffle (xcoord);
		InvokeRepeating ("spawn", 2, 2);
	}

	// Update is called once per frame
	void Update () {		
			
	}

	void spawn() {
		if (times > 3) {
			CancelInvoke ();
		} else {
			g1 = Instantiate (g, new Vector3 (xcoord [times], 5, 145), Quaternion.Euler (-90, 0, -180))as GameObject;
			times++;
		}
	}

	void reshuffle(float[] texts)

	{
		for (int t = 0; t < texts.Length; t++) {
			float tmp = texts [t];
			int r = Random.Range (t,texts.Length);
			texts [t] = texts [r];
			texts [r] = tmp;
		}
	}
}
