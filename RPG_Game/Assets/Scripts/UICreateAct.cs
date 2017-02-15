using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICreateAct : UIBase{

    public Button btn;
    public InputField newA,newP,newE,saveAns;
    string newac, newpas, newemail, newans;
    int i =0;
    public string uri = "http://10.2.1.109:8080/TestJavaWed/UnityForLogin?";
    public string paramter;

    public override void OnEnter()
    {
        Debug.Log("I am UICreateAct");
        btn.onClick.AddListener(SentNew);
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


    void SentNew() {
        CheckPasLength();
        if (i == 1)
        {
            ProcLogin.Instance.CloseCreateActUI();
            ProcLogin.Instance.OpenLoginUI();
        }
        else
        {
            Debug.Log("密碼錯誤");
        }

        paramter += "NewAccount" + newA.text+ "&" + "NewPassword" + newP.text + "&" + "NewEmail" + newE.text + "&" + "NewAns" + saveAns;   
        StartCoroutine(SentServer(uri + paramter));
    }



    void CheckPasLength()
    {

        newpas = newP.text;
        if (newpas.Length < 6 && newpas.Length != 0)
        {
            i = -1;
            Debug.Log("NO");
        }
        else if (newpas.Length >= 6)
        {
            i = 1;
            Debug.Log("YES");
        }
        else {
            i = 0;
            Debug.Log("null");
        }
        
       
    }

    public override void OnLeave()
    {
        Destroy(this.gameObject);
    }
}
