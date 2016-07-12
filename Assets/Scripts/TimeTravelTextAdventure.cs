using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TimeTravelTextAdventure : MonoBehaviour {
	
	string currentRoom = "Control Room"; // remembers our current location in world

		bool hasKingsPendant = false;
		bool hasHyperDrive = false;

	void Update () {

		string textBuffer = "You are in: " + currentRoom; // shows current location to the player

		if (currentRoom == "Control Room") { // Introduction text
			textBuffer += "\n\n\nYou are a time traveler, exploring the realms of time and space for fun.";
			textBuffer += "\n\nWhen would you like to go?";
			textBuffer += "\nPress [J] to go to the Jurassic Era";
			textBuffer += "\nPress [A] to go to the Ancient City of Atlantis";
			textBuffer += "\nPress [R] to go to the Renaissance";
			textBuffer += "\nPress [E] to go to Earth 2107 A.D.";
			textBuffer += "\nPress [N] to go to the Nebulo 9";

			if (Input.GetKeyDown (KeyCode.J)) { // if player pushes J...
				currentRoom = "Jurassic Era";
			} else if (Input.GetKeyDown (KeyCode.A)) {// if player pushes A...
				currentRoom = "Atlantis";
			} else if (Input.GetKeyDown (KeyCode.R)) {// if player pushes R...
				currentRoom = "The Renaissance";
			} else if (Input.GetKeyDown (KeyCode.E)) {// if player pushes E...
				currentRoom = "Earth 2107 A.D.";
			} else if (Input.GetKeyDown (KeyCode.N)) {// if player pushes N...
				currentRoom = "Nebulo 9";
			}

		} else if (currentRoom == "Jurassic Era") { // Jurassic Era Room
			textBuffer += "\n\n\nJurassic Era it is!";
			textBuffer += "\n\nYou walk out of your time machine and a T-Rex is staring you in the face. ";
			textBuffer += "Maybe this wasn't a good idea...";

			textBuffer += "\n\nPress [C] to go back to the Control Room."; // Prompt to return to the main room
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		} else if (currentRoom == "Atlantis") { // Atlantis Room - The first gate is here.  It's unlocked with a key from the Renissance Room
			textBuffer += "\n\n\nTo Atlantis then! Don't forget your bathing suit!";

			if (hasKingsPendant == false) { // First Gate checking for key
				textBuffer += "\n\nThe gates are locked.  There seems to be a pendant shaped hole in the door. ";
				textBuffer += "What a strange looking mechanism...";
			} else {
				textBuffer += "\n\nThe King's Pendant you found fits perfectly in door's hole! The gates open and you are greeted with open arms. ";
				textBuffer += "King Raigen shows you all around the city.  There are fish with colors the likes of which you've never seen! "; 
				textBuffer += "Fortunately all of the sharks are domesticated too.";
			}

			textBuffer += "\n\nPress [C] to go back to the Control Room."; // Prompt to return to the main room
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";
			
		} else if (currentRoom == "The Renaissance") { // Renaissance Room - First key is here
			textBuffer += "\n\n\nOff to the Renaissance, Lords and Ladies!";
			textBuffer += "\n\nYou exit your time machine right in the middle of a market. ";
			textBuffer += "There's a man selling coconuts that he claims to have found, and another man with a cart yelling 'BRING OUT YER DEAD!'";
			textBuffer += "\n\nAmidst the crowded streets, you find an 'A' shaped pendant on the ground. It looks shiny so you decide to take it!";
			hasKingsPendant = true; // Pick up first key

			textBuffer += "\n\nPress [C] to go back to the Control Room."; // Prompt to return to the main room
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		} else if (currentRoom == "Earth 2107 A.D.") { // Earth 2107 A.D. Room - Second key is here
			textBuffer += "\n\n\nUgh... I SUPPOSE you can go to Earth.";
			textBuffer += "\n\nThe moment you step outside, you see lazers flying across a desolate wasteland. ";
			textBuffer += "The people of Earth are at war with each other again.  It seems like not much as changed in 100 years...";

			textBuffer += "\n\nOn the bright side, you find a glowing fuel box that could probably fit in your Hyperdrive Engine!";
			hasHyperDrive = true; // Pick up second key

			textBuffer += "\n\nPress [C] to go back to the Control Room."; // Prompt to return to the main room
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";

		} else if (currentRoom == "Nebulo 9") { // Nebulo 9 room - Second Gate is here.  It's unlocked with a key from the Earth 2107 A.D. Room
			textBuffer += "\n\n\nLet's go to Nebulo 9.  Which is.... IN SPAAAAAAAAACE!!!";

			if (hasHyperDrive == false) { // Second Gate checking for key
				textBuffer += "\n\nUnfortunately Nebulo 9 is so far in the future that your time machine doesn't have the power to travel there. ";
				textBuffer += "If you had fuel for your Hyperdrive Engine, you might be able to make it though!";
			} else {
				textBuffer += "\n\nYou travel to Nebulo 9 in the blink of an eye! When you arrive there are a bunch of dudes playing the best guitar solos you've ever heard. ";
				textBuffer += "Everyone you pass by greets you by snapping and pointing their fingers while saying 'Hope you're excellent bro!'";
				textBuffer += "\n\nThe future seems totally radical... dude.";
			}

			textBuffer += "\n\nPress [C] to go back to the Control Room."; // Prompt to return to the main room
			if (Input.GetKeyDown (KeyCode.C))
				currentRoom = "Control Room";
			
		}
		GetComponent<Text>().text = textBuffer;
	}
}// CLOSES OUT UPDATE() scope