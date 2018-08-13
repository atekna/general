using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct TribalWarrior_Class {

	//ATTRIBUTES ROLL THROUGH 20 LIKE D&D rolls

	public string Name { get; set; }

	public int Health { get; set; }
	public int Manna  { get; set; }

	public int Strength { get; set; }
	public int Dexterity { get; set; }
	public int Wisdom { get; set; }
	public int Constitution { get; set; }



		


	public TribalWarrior_Class (string rname, int rhealth, int rmanna, int rstrength, int rdexterity, int rwisdom, int rconstitution){

		this.Name = rname;
		this.Health = rhealth;
		this.Manna = rmanna;
		this.Strength = rstrength;
		this.Dexterity = rdexterity;
		this.Wisdom = rwisdom;
		this.Constitution = rconstitution;

	}



	private TribalWarrior_Class(string rname){
		this.Name = rname;
		this.Health = Random.Range (0, 18);
		this.Manna = Random.Range (0, 18);
		this.Strength = Random.Range (0, 18);
		this.Dexterity= Random.Range (0, 18);
		this.Wisdom = Random.Range (0, 18);
		this.Constitution = Random.Range (0, 18);
	}


	public static TribalWarrior_Class GetRandomChar(string name){
		return new TribalWarrior_Class (name);
	}


	public string GetChar(){
		string charStats = "";
		charStats += "Name:" + this.Name + " ";
		charStats += "Health" + this.Health + " ";
		charStats += "Manna" + this.Manna + " ";
		charStats += "Strength" + this.Strength + " ";
		charStats += "Dexterity" + this.Dexterity + " ";
		charStats += "Wisdom" + this.Wisdom + " ";
		charStats += "Constitution" + this.Constitution + " ";


		return charStats;
			
	}



}

	


