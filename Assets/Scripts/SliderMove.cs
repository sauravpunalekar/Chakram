using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMove : MonoBehaviour {
	public Slider s;
	int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count % 2 == 0) {
			if (s.value < s.maxValue) {
				moveup ();
			} else {
				count++;
			}
		}
		if (count % 2 == 1) {
			if (s.value > s.minValue) {
				movedown ();
			} else {
				count++;
			}
		}
	}
	void moveup()
	{
		s.value += 1;
	}
	void movedown()
	{
		s.value -= 1;
	}
}
