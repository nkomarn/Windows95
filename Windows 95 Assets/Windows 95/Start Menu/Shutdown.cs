using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shutdown : MonoBehaviour {

	public Button shutdown;

	// Use this for initialization
	void Start () {
		Button shutdownBtn = shutdown.GetComponent<Button> ();
	}

	void Update () {
		Button shutdownBtn = shutdown.GetComponent<Button> ();
		shutdownBtn.onClick.AddListener (shutdownEvent);
	}

	void shutdownEvent() {
		GlobalVariables.shutdown = true;
		GlobalVariables.startmenuEnabled = false;
		GlobalVariables.fixStart = true;
	}
}
