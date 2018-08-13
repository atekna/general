using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class RPG : MonoBehaviour {

	ArrayList heroes = new ArrayList();
	TribalWarrior_Class[] tester; //I am just seeing what this does
	public Text healthDisplay;
	public Text nameDisplay;
	public Image faceDisplay;




	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {



	}


	public void BuildWarrior(){

		TribalWarrior_Class warrior = TribalWarrior_Class.GetRandomChar ("Volburts");
		heroes.Add (warrior);
		Debug.Log (warrior.GetChar ());
	}



	public void BuildShaman(){

		Shaman_Class shaman = Shaman_Class.GetRandomChar ("Heidl");
		heroes.Add (shaman);
		Debug.Log (shaman.GetChar ());

	}


	public void SendDisplay(){
	

	
	}

		


}
