using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TimeTravelTextAdventure : MonoBehaviour {
	
	string currentRoom = "Lobby"; // remembers our current location in world

		bool hasStudentID = false;
		void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			textBuffer += "\nYou see the security guard.";
			textBuffer += "\nPress [W] to go to elevators";
			textBuffer += "\nPress [S] to go outside";

			if (Input.GetKeyDown (KeyCode.W)) { // if player pushes W...
				currentRoom = "Elevators";
			} else if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "Outside";
			}
		} else if (currentRoom == "Elevators") {
			textBuffer += "\nYou're waiting.";
			if (hasStudentID == false) {
				textBuffer += "\nYou can't go in without your ID card, though...";
			} else {
				textBuffer += "\nYou swipe your Student ID and the guard smiles.";
			}
		} else if (currentRoom == "Outside") {
			textBuffer += "\nIT IS REALLY HOT WHAT IS WRONG WITH YOU";
			textBuffer += "\nPress [S] to go back INSIDE, LIKE RIGHT NOW";
			textBuffer += "\n(Oh hey you found your student ID on the floor!)";
			hasStudentID = true;

			// when "if" statement has no curly braces, then only the next line happens
			if (Input.GetKeyDown (KeyCode.S))
				currentRoom = "Lobby";
		}
		// let's "render out" our text buffer and display it on-screen
		// we need to do this at the end, otherwise we'll display text too soon
		GetComponent<Text>().text = textBuffer;
	}// CLOSES OUT UPDATE() scope
}