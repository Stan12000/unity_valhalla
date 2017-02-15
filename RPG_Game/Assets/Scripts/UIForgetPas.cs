using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIForgetPas : UIBase{

    public Button btn;
    public InputField checkA, checkE, checkS;
    public string uri = "http://10.2.1.109:8080/TestJavaWed/UnityForLogin?";
    public string paramter;


    public override void OnEnter()
    {
        Debug.Log("I am UIForgetPas");
        btn.onClick.AddListener(SentOK);

    }

    IEnumerator SentServer(string path)
    {
        WWW www = new WWW(path);
        yield return www;

        if (www.error != null)
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


    void SentOK() {

        paramter += "Account" +checkA.text + "&" + "Email" + checkE.text + "&" + "SaveQ" +checkS.text;
     
        StartCoroutine(SentServer(uri + paramter));

        ProcLogin.Instance.CloseForegetPasUI();
        ProcLogin.Instance.OpenLoginUI();
    }

    public override void OnLeave()
    {
        Destroy(this.gameObject);
    }

}
