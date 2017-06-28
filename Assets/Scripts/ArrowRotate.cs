using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotate : MonoBehaviour {
	int flag =0;
	public GameObject g;
	// Use this for initialization
	void Start () {
		//g = GameObject.Find ("Arrow");
		
	}

	// Update is called once per frame
	void Update () {
		if (flag==0) {
			MoveRight ();
		
			if (g.transform.rotation.eulerAngles.y >= 32 && g.transform.rotation.eulerAngles.y < 34 ) {			
				flag = 1;
			}
		}
		if (flag == 1) {
			MoveLeft ();
			if (g.transform.rotation.eulerAngles.y <= 328 && g.transform.rotation.eulerAngles.y > 326) {			
				flag = 0;
			}
		}
		/*Debug.Log (g.transform.rotation.eulerAngles.y);
		if (g.transform.rotation.eulerAngles.y > 32 || g.transform.rotation.eulerAngles.y < 328) {
			Debug.Log ("change flag");
			flag = -flag;
		}
		Debug.Log (flag);
		MoveRight ();*/
	}
	void MoveRight (){
		g.transform.Rotate(0,g.transform.rotation.y+1,0);
		//g.transform.Rotate(0,g.transform.rotation.y+flag,0);
	}
	void MoveLeft(){
		g.transform.Rotate(0,g.transform.rotation.y-1,0);
		return;	
	}
}
