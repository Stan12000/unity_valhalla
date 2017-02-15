using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStart : UIBase {

	public Button btn;
 
	// Use this for initialization
	void Start () {
		Debug.Log ("I am UIStart");
        
        btn.onClick.AddListener(callLogin);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void callLogin()
    {

        if (ProcLogin.Instance.loginUI == true){ ProcLogin.Instance.CloseLoginUI(); }
        else {
            if (ProcLogin.Instance.forgetPasUI == true) { ProcLogin.Instance.CloseForegetPasUI(); }
            if (ProcLogin.Instance.createActUI == true) { ProcLogin.Instance.CloseCreateActUI(); }
 
            ProcLogin.Instance.OpenLoginUI();
             }
    }


}
