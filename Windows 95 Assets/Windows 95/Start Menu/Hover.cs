using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Button button;
	public Sprite defaultLook;
	public Sprite hoverLook;

	// Use this for initialization
	void Start () {
		Button btn = button.GetComponent<Button> ();
		btn.gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		if (GlobalVariables.startmenuEnabled == true) {
			Button btn = button.GetComponent<Button> ();
			btn.gameObject.SetActive (true);
		}
		if (GlobalVariables.startmenuEnabled == false) {
			Button btn = button.GetComponent<Button> ();
			btn.gameObject.SetActive (false);
		}
	}

	public void OnPointerEnter (PointerEventData eventData) {
		Button btn = button.GetComponent<Button> ();
		btn.image.sprite = hoverLook;
	}

	public void OnPointerExit (PointerEventData eventData) {
		Button btn = button.GetComponent<Button> ();
		btn.image.sprite = defaultLook;
	}
}
