using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class dataSend : MonoBehaviour {
	private ArduinoTest cube1;
	private ArduinoTest2 cube2;
    SerialPort arduino;
	// Use this for initialization
	void Start () {

		arduino = new SerialPort ("/dev/tty.usbmodem1411", 9600);
        arduino.Open();

		cube1 = GameObject.Find("Cube").GetComponent<ArduinoTest>();
		cube2 = GameObject.Find("Cube (1)").GetComponent<ArduinoTest2>();

	}
	
	// Update is called once per frame
	void Update () {

        if (arduino.IsOpen) {
            if (cube1.getCube() == true) {
                arduino.Write("1");
                Debug.Log("Sending 1");
            }
			else if (cube2.getCube() == true) {
                arduino.Write("2");
                Debug.Log("Sending 2");
            }
            else {
                arduino.Write("0");
                Debug.Log("Sending 0");
            }
        }

    }
}