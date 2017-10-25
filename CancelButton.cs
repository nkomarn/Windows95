using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CancelButton : MonoBehaviour {
	public Button cancelBUTTON;
	public GameObject window;
	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		cancelBUTTON.onClick.AddListener (cancel);
	}
	void cancel(){
		window.SetActive (false);
	
	}
}
