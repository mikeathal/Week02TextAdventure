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
			// typing "\n" in a string means "line break"
			textBuffer += "\nYou see the security guard.";
			// the line of code below is the SAME as the line of code above
			// textBuffer = textBuffer + "\nYou see the security guard.";

			textBuffer += "\nPress [W] to go to elevators";
			textBuffer += "\nPress [S] to go outside";

			if (Input.GetKeyDown (KeyCode.W)) { // if player pushes W...
				currentRoom = "Elevators";
			} else if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "Outside";
			}
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