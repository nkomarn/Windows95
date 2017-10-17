using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAction : MonoBehaviour {

	public Button start;
	public Sprite defaultLook;
	public Sprite pressedLook;

	// Use this for initialization
	void Start () {
		Button startButton = start.GetComponent<Button> ();
		startButton.onClick.AddListener (startPressed);
	}

	void Update () {
		if (GlobalVariables.fixStart == true) {
			Button startButton = start.GetComponent<Button> ();
			startButton.image.sprite = defaultLook;
			GlobalVariables.fixStart = false;
			GlobalVariables.startmenuEnabled = false;
		}
	}

	void startPressed() {
		if (GlobalVariables.startmenuEnabled == false) {
			Button startButton = start.GetComponent<Button> ();
			startButton.image.sprite = pressedLook;

			GlobalVariables.startmenuEnabled = true;
		} else if (GlobalVariables.startmenuEnabled == true) {
			Button startButton = start.GetComponent<Button> ();
			startButton.image.sprite = defaultLook;

			GlobalVariables.startmenuEnabled = false;
		}
	}
}
