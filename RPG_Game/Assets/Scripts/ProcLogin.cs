using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcLogin : ProcBase {

	public UIManager uiManager;
	public UIStart startUI;

	public override void OnEnter ()
	{
		Debug.Log ("I am ProcLogin");

		// use UIManager to open UIStart here
		startUI = (UIStart)GameMain.Instance.uiManager.CreateUI (UIManager.UIID.Start);
		//startUI = (UILogin)GameMain.Instance.uiManager.CreateUI (UIManager.UIID.Login);
		//GameObject.Find ("GameMain").GetComponent<GameMain> ();
	}
}
