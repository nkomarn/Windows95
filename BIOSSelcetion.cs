using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BIOSSelcetion : MonoBehaviour {
	public Sprite systemInformation;
	public Sprite systemInformation2;
	public SpriteRenderer SI;
	public Sprite systemSettings;
	public Sprite systemSettings2;
	public SpriteRenderer SyS;
	public Sprite dateAndTime;
	public Sprite dateAndTime2;
	public SpriteRenderer DAT;
	public Sprite startOptions;
	public Sprite startOptions2;
	public SpriteRenderer SO;
	public Sprite bootManager;
	public Sprite bootManager2;
	public SpriteRenderer BM;
	public Sprite systemEventLogs;
	public Sprite systemEventLogs2;
	public SpriteRenderer SEL;
	public Sprite userSecurity;
	public Sprite userSecurity2;
	public SpriteRenderer US;
	public Sprite saveSettings;
	public Sprite saveSettings2;
	public SpriteRenderer SaS;
	public Sprite restoreSettings;
	public Sprite restoreSettings2;
	public SpriteRenderer RS;
	public Sprite loadDefaultSettings;
	public Sprite loadDefaultSettings2;
	public SpriteRenderer LDS;
	public Sprite exitSetup;
	public Sprite exitSetup2;
	public SpriteRenderer ES;
	private int selection;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			selection = (selection + 1);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			selection = (selection - 1);
		}
		if (selection > 22) {
			selection = 1;
		}
		if (selection < 1) {
			selection = 22;
		}
	}


	void SelectChange(){
		switch (selection) {
		default:
			SI.sprite = systemInformation;
			break;
		case 1:
			SI.sprite = systemInformation;
			break;
		case 2:
			SI.sprite = systemInformation;
			break;
		case 3:
			SyS.sprite = systemInformation2;
			break;
		case 4:
			SyS.sprite = systemInformation;
			break;
		case 5:
			DAT.sprite = systemInformation2;
			break;
		case 6:
			DAT.sprite = systemInformation;
			break;
		case 7:
			SO.sprite = systemInformation2;
			break;
		case 8:
			SO.sprite = systemInformation;
			break;
		case 9:
			BM.sprite = systemInformation2;
			break;
		case 10:
			BM.sprite = systemInformation;
			break;
		case 11:
			SEL.sprite = systemInformation2;
			break;
		case 12:
			SEL.sprite = systemInformation;
			break;
		case 13:
			US.sprite = systemInformation2;
			break;
		case 14:
			US.sprite = systemInformation;
			break;
		case 15:
			SaS.sprite = systemInformation2;
			break;
		case 16:
			SaS.sprite = systemInformation;
			break;
		case 17:
			RS.sprite = systemInformation2;
			break;
		case 18:
			RS.sprite = systemInformation;
			break;
		case 19:
			LDS.sprite = systemInformation2;
			break;
		case 20:
			LDS.sprite = systemInformation;
			break;
		case 21:
			ES.sprite = systemInformation2;
			break;
		case 22:
			ES.sprite = systemInformation;
			break;
		}
	}
}
