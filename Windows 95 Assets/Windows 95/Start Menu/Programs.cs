using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Programs : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter (PointerEventData eventData) {
		GlobalVariables.programsSubmenu = true;
		Debug.Log("I am over something");
	}

	public void OnPointerExit (PointerEventData eventData) {
		GlobalVariables.programsSubmenu = false;
		Debug.Log("I am not over something");
	}
}
