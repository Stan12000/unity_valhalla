using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	
	public enum UIID
	{
		Start=0,
		Login,
		Loading,
		Job,
		CharName,
		ForeWord,
		Main,

		TOTAL,
	}

	[SerializeField]
	UIBase[] uis = new UIBase[(int)UIID.TOTAL - 1];

	public UIBase CreateUI(UIID uiID)
	{
		// 1. Get UI file name via UIID
		// 2. Use UI file name to load UI from resources
		// 3. GameObject.Instantsiate

		// hint: you may need an array to store ui file names

		// temp, to avoid error
		return null;
	}
}