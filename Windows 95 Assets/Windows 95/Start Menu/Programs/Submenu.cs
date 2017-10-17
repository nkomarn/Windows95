using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submenu : MonoBehaviour {

	public GameObject submenu;

	// Use this for initialization
	void Start () {
		submenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.programsSubmenu == true) {
			GameObject menu = submenu.GetComponent<GameObject> ();
			menu.SetActive (true);
			menu.gameObject.SetActive (true);
		}
		if (GlobalVariables.programsSubmenu == false) {
			GameObject menu = submenu.GetComponent<GameObject> ();
			menu.SetActive (false);
			menu.gameObject.SetActive (false);
		}
	}

	void OnMouseEnter() { Debug.Log("I am over something"); }
}
