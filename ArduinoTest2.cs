﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoTest2 : MonoBehaviour {
	private bool cube2;
	public bool getCube() {
        return cube2;
    }
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (cube2 == true) {
            Debug.Log("cube2 = True");
		}
		else if (cube2 == false) {
            Debug.Log("cube2 = False");
		}

    }
    private void OnTriggerEnter(Collider other) {
        cube2 = true;
    }
	private void OnTriggerExit(Collider other) {
        cube2 = false;
    }
}