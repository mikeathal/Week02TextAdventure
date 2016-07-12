using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TimeTravelTextAdventure : MonoBehaviour {
	
string currentRoom = "Lobby"; // remembers our current location in world

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		// if I declare a variable inside Update(),
		// then I can ONLY use this variable inside Update() !!
		// also, a "buffer" is a staging area to prepare data
		string textBuffer = "You are currently in: " + currentRoom;

		if ( currentRoom == "Lobby" ) {
		// all of your LOBBY code will go here later!
		} else if ( currentRoom == "Elevators" ) {
		// all of your ELEVATORS code will go here later!
		} else if ( currentRoom == "Outside" ) {
		// all of your OUTSIDE code will go here later!
		}
		// let's "render out" our text buffer and display it on-screen
		// we need to do this at the end, otherwise we'll display text too soon
		GetComponent<Text>().text = textBuffer;
	}// CLOSES OUT UPDATE() scope
}