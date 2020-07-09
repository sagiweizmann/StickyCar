using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField user_inp;
    public InputField pass_inp;
    public Button login;
    public Button ok;
    public Text showtxt;
    public Image msgbox;
    public Button back;
    void Start()
    {
        pass_inp.inputType= InputField.InputType.Password;
        back.onClick.AddListener(delegate () { back_onclick(); });
        login.onClick.AddListener(delegate () { StartCoroutine(Login_Called()); });
        msgbox.gameObject.SetActive(false);
    }
    IEnumerator Login_Called()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", user_inp.text);
        form.AddField("password", pass_inp.text);
        WWW www = new WWW("http://147.234.32.72/server/login.php", form);
        yield return www;
        if(www.text[0]=='0')
        {
            DBManager.username = user_inp.text;
            DBManager.coins = int.Parse(www.text.Split('\t')[1]);
            DBManager.id = int.Parse(www.text.Split('\t')[2]);
            DBManager.currentskin = int.Parse(www.text.Split('\t')[3]);
            Debug.Log(DBManager.currentskin);
            Messagebox_show("Logged in Successfully!",1);
            
        }
        else
        {
            Messagebox_show("User login failed. Error # " + www.text,2);
        }
    }

    void Messagebox_show(string showstr,int state)
    {
        msgbox.gameObject.SetActive(true);
        showtxt.text = showstr;
        if(state==1)
        {
            ok.onClick.AddListener(delegate () { ok_onclick_nextscene(); });
        }
        if (state == 2)
        {
            ok.onClick.AddListener(delegate () { ok_onclick(); });
        }
        
    }
    void ok_onclick()
    {
        msgbox.gameObject.SetActive(false);
    }
    void ok_onclick_nextscene()
    {
        msgbox.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
       // SceneManager.LoadScene("Achivements", LoadSceneMode.Additive);
    }
    void back_onclick()
    {
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }
}
