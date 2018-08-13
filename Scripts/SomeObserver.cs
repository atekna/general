using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObserver : MonoBehaviour {

	CameraRaycaster cameraRaycaster;


	// Use this for initialization
	void Start () {

		cameraRaycaster = GetComponent<CameraRaycaster>();
		cameraRaycaster.layerChangeObserver += GeneralHandling; //wants to add itself to the pool of observers via the layerChangeObserver delegate in CameraRaycaster.cs

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GeneralHandling() {
		print ("This is a generic statement that is handled elsewhere.");
	}

}


//this is a test script. it can be deleted when I wish