using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuRenderer : MonoBehaviour {

	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<SpriteRenderer> ();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.startmenuEnabled == true) {
			rend.enabled = true;
		}

		if (GlobalVariables.startmenuEnabled == false) {
			rend.enabled = false;
		}
	}
}
