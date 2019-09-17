using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoTest : MonoBehaviour {
	private bool cube1;
	public bool getCube() {
        return cube1;
    }
	
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

		if (cube1 == true) {
            Debug.Log("cube1 = True");
		}
		else if (cube1 == false) {
            Debug.Log("cube1 = False");
		}

    }
    private void OnTriggerEnter(Collider other) {
        cube1 = true;
    }
	private void OnTriggerExit(Collider other) {
        cube1 = false;
    }
}