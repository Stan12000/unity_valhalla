using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UIManager : MonoBehaviour {

	string[] fileName = {"UIStart","UILogin","UICreateAct","UIForgetPas","UILoading","UIJob","UICharName","UIForeWord","UIMain"};
	RectTransform rectTrans;

	public enum UIID
	{
		Start=0,
		Login,
        CreateAct,
        ForgetPas,
		Loading,
		Job,
		CharName,
		ForeWord,
		Main,
        

		TOTAL,
	}
		
	void Awake()
	{
		rectTrans = this.GetComponent<RectTransform> ();
	}

	public UIBase CreateUI(UIID uiID)
	{
		UIBase rObj = null;
		UIBase uiObj = null;

		// 1. Get UI file name via UIID
		string name = fileName[(int)uiID];

		// 2. Use UI file name to load UI from resources
		rObj = Resources.Load("Prefabs/Menus/" + name, typeof(UIBase)) as UIBase;

		// 3. GameObject.Instantiate
		uiObj = GameObject.Instantiate(rObj);

		uiObj.GetComponent<RectTransform> ().SetParent (rectTrans);
		uiObj.transform.localScale = Vector3.one;
		uiObj.transform.localPosition = Vector3.zero;

		// hint: you may need an array to store ui file names

		return uiObj;

	}

   
}