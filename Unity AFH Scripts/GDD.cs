using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDD : MonoBehaviour {

	public void Start(){

	print("I will have 4 scenes. From title there is the story, then it loads to the town scene. From the town scene, I can either go to my Elder Yurt," +
		"view my adventurers, hire new ones, build new buildings, or send on an expedition. I can see my money and population in the upper right." +
		"I start with one adventurer and only after sending him out the first time and he coming back, can I really play the game freely and hire new adventurers." +
		"Time, and the story, essentially progress as adventurers clear dungeons. We don't go by days and hours, but rather by cleared dungeons. I can't control my " +
		"adventurers directly, but rather have to rely on them banding together to defeat threats. They can go in parties of up to four, and they will randomly " +
		"chose other party members for their groups when I push 'day start'. The logic will randomize parties based on levels (higher levels with higher levels), and" +
		"only 1 shaman per party." +
		"If someone dies, then they are gone for good (unless someone in the party has a 'Blood of the Creator' potion, which is rare and finite. There might be 4 in the whole" +
		"game. " +
		"Adventurers can only shop for goods in town on their days off, so I have to not schedule a dungeon day." +
		"The game is only 300 days and when I press 'Start Day', then one day is shaved off the time and dungeons will commence, and leftover adventurers will shop." +
		"I can send up to 3 party per day, all of which can have up to 4 people." +
		"I must give each party a leader, but can't assign other members." +
		"Members can have affinity towards each other, or dislike, which happens randomly when they adventure together. The stat is hidden." +
		"Only adventurers not assigned will shop. When I press begin day, the caluclations happen and I can see what actions happened that day." +
		"There is a limit of 16 adventurers." +
			"---that's all for now!");
		
		}

}

