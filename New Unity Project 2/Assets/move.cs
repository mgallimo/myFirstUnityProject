﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float horizontalSpeed = .5f; 
	public float verticalSpeed = .2f;


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-horizontalSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Translate (horizontalSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.Translate (0, -verticalSpeed, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.Translate (0, verticalSpeed, 0);
		}
	
		// Classes are blueprints for object-oriented programming.

	}
}
