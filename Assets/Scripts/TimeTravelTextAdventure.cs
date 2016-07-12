using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TimeTravelTextAdventure : MonoBehaviour {
	
	string currentRoom = "Control Room"; // remembers our current location in world

		bool hasKingsPendant = false;
		bool hasHyperDrive = false;
	void Update () {
		string textBuffer = "You are in: " + currentRoom;

		if (currentRoom == "Control Room") {
			textBuffer += "\n\nYou are a time traveler, exploring the realms of time and space for fun.";
			textBuffer += "\n\nWhen would you like to go?";
			textBuffer += "\nPress [J] to go to the Jurassic Era";
			textBuffer += "\nPress [A] to go to the Ancient City of Atlantis";
			textBuffer += "\nPress [R] to go to the Rennaisance";
			textBuffer += "\nPress [E] to go to Earth 2107 A.D.";
			textBuffer += "\nPress [N] to go to the Nebulo 9";

			if (Input.GetKeyDown (KeyCode.J)) { // if player pushes J...
				currentRoom = "Jurassic Era";
			} else if (Input.GetKeyDown (KeyCode.A)) {
				currentRoom = "Atlantis";
			} else if (Input.GetKeyDown (KeyCode.R)) {
				currentRoom = "The Rennaisance";
			} else if (Input.GetKeyDown (KeyCode.E)) {
				currentRoom = "Earth 2107 A.D.";
			} else if (Input.GetKeyDown (KeyCode.N)) {
				currentRoom = "Nebulo 9";
			}

		} else if (currentRoom == "Jurassic Era") {
			textBuffer += "\n\nJurassic Era it is!";
			textBuffer += "\n\nYou walk out of your time machine and a T-Rex is staring you in the face.";
			textBuffer += "\nMaybe this wasn't a good idea...";
			textBuffer += "\n\nPress [C] to go back to the Control Room.";
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		} else if (currentRoom == "Atlantis") {
			textBuffer += "\n\nTo Atlantis then! Don't forget your bathingsuit!";

			if (hasKingsPendant == false) {
				textBuffer += "\n\nThe gates are locked.  There seems to be a pendant shaped hole in the door. ";
				textBuffer += "What a strange looking mechanism...";
			} else {
				textBuffer += "\n\nThe King's Pendant you found fits perfectly! The gates open and you are greeted with open arms. ";
				textBuffer += "King Raigen shows all around the city.  There are fish with colors the likes of which you've never seen! "; 
				textBuffer += "Fortunately all of the sharks are domesticated too.";
			}
			textBuffer += "\n\nPress [C] to go back to the Control Room.";
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";
			
		} else if (currentRoom == "The Rennaisance") {
			textBuffer += "\n\nOff to The Rennaisance, Lords and Ladies!";
			textBuffer += "\n\nYou exit your time machine right in the middle of a market.";
			textBuffer += "\nThere's a man selling coconuts that he claims to have found, and another man with a cart yelling 'BRING OUT YER DEAD!'";
			textBuffer += "\n\nAmidst the crowded streets, you find an 'A' shaped pendant on the ground. It looks shiny so you decide to take it!";
			hasKingsPendant = true;

			textBuffer += "\n\nPress [C] to go back to the Control Room.";
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		} else if (currentRoom = "Earth 2107 A.D.") {
			textBuffer += "\n\nUgh... I SUPPOSE you can go to Earth.";
			textBuffer += "\n\nThe moment you step outside, see lazers are flying everywhere across a desolate wasteland. ";
			textBuffer += "The people of Earth are at war with each other again.  It seems like not much as changed in 100 years.";

			textBuffer += "\n\nOn the bright side, you find a glowing fuel box that could probably fit in your Hyperdrive Engine!";
			hasHyperDrive = true;

			textBuffer += "\n\nPress [C] to go back to the Control Room.";
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		}
		GetComponent<Text>().text = textBuffer;
	}
}// CLOSES OUT UPDATE() scope