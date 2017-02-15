using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILogin : UIBase {
   
    public Button btn,google,fb,forgetpas,createact;
    public InputField account,password;
    private bool exit;
    string ac,pas;
    public string uri = "http://10.2.1.109:8080/TestJavaWed/UnityForLogin?";
    public string paramter;

    public override void OnEnter() 
	{
        Debug.Log("I am UILogin");
        forgetpas.onClick.AddListener(callforgetpas);
        createact.onClick.AddListener(callcreatact);
        btn.onClick.AddListener(CallEnter);       
    }

    void CallEnter() {
        paramter += "UserName=" + account.text + "&";
        paramter += "PassWord=" + password.text;
        StartCoroutine(login(uri + paramter));
    }

    IEnumerator login(string path)
    {
        WWW www = new WWW(path);
        yield return www;

        if(www.error != null)
        {
            Debug.Log(www.error);
        }
        else
        {
            if (www.text.Equals("true"))
            {
                print("Login Success");
            }
            else
            {
                print("Login Fail......");
            }
        }
    }

    void callcreatact()
    {
        ProcLogin.Instance.CloseLoginUI();
        ProcLogin.Instance.OpenCreateActUI();
            
    }

    void callforgetpas()
    {
        ProcLogin.Instance.CloseLoginUI();
        ProcLogin.Instance.OpenForgetPasUI();
        
    }

    void callenter() {
        ac = account.text;
        pas = password.text;
        Debug.Log(ac + ":" + pas);
    }

    public override void OnLeave()
    {
        Destroy(this.gameObject);
    }
}
