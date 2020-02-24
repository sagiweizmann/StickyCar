using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField user_inp;
    public InputField pass_inp;
    public Button login;
    public Button ok;
    public Text showtxt;
    public RawImage msgbox;
    void Start()
    {
        pass_inp.inputType= InputField.InputType.Password;
        login.onClick.AddListener(delegate () { StartCoroutine(Login_Called()); });

    }
    IEnumerator Login_Called()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", user_inp.text);
        form.AddField("password", pass_inp.text);
        WWW www = new WWW("http://localhost/server/login.php", form);
        yield return www;
        if(www.text[0]=='0')
        {
            DBManager.username = user_inp.text;
            DBManager.coins = int.Parse(www.text.Split('\t')[1]);
            Debug.Log(DBManager.coins.ToString());
            Debug.Log("logged in");
            
        }
        else
        {
            Debug.Log("User login failed. Error # " + www.text);
        }
    }
    void Messagebox_show(string showstr)
    {
        showtxt.text = showstr;
        ok.onClick.AddListener(delegate () { ok_onclick(); });
        
    }
    void ok_onclick()
    {

    }
}
