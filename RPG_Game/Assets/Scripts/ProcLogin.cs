using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ProcLogin : ProcBase {

	public UIManager uiManager;
	public UIStart startUI;
    public UILogin loginUI;
    public UICreateAct createActUI;
    public UIForgetPas forgetPasUI;


    private static ProcLogin _instance = null;
    public static ProcLogin Instance
    {
        get
        {
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }


    public override void OnEnter ()
	{
		Debug.Log ("I am ProcLogin");
        
            // use UIManager to open UIStart here
            startUI = (UIStart)GameMain.Instance.uiManager.CreateUI(UIManager.UIID.Start);
            //startUI = (UILogin)GameMain.Instance.uiManager.CreateUI (UIManager.UIID.Login);
            //GameObject.Find ("GameMain").GetComponent<GameMain> ();
            
        
        
     
	}


    public void OpenLoginUI() {
        loginUI = (UILogin)GameMain.Instance.uiManager.CreateUI (UIManager.UIID.Login);
        loginUI.OnEnter();
        
    }
    public void CloseLoginUI() {
        loginUI.OnLeave();
    }

    public void OpenForgetPasUI() {
        forgetPasUI = (UIForgetPas)GameMain.Instance.uiManager.CreateUI(UIManager.UIID.ForgetPas);
        forgetPasUI.OnEnter();
    }
    public void CloseForegetPasUI() {
        forgetPasUI.OnLeave();
    }
    public void OpenCreateActUI() {
        createActUI = (UICreateAct)GameMain.Instance.uiManager.CreateUI(UIManager.UIID.CreateAct);
        createActUI.OnEnter();
    }
    public void CloseCreateActUI() {
        createActUI.OnLeave();
    }
}
