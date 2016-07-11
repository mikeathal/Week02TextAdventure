using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	// declare a Text variable so that this code can talk to it
	public Text myTextThing;

	int currentPoints = 0;

	// Use this for initialization
	void Start () {
		
		myTextThing.text = "Current Score:" + currentPoints.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		// give player 1 point if they press Space
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			currentPoints += 1;
			myTextThing.text = "Current Score: " + currentPoints.ToString();
		}

		if (Input.GetKeyDown (KeyCode.X)) {
			currentPoints += 1000;
		}

		if (currentPoints >= 100) {
			myTextThing.text = "Winner Winner, Chicken Dinner!";
		}

	}
}
