using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public InputField user_inp;
    public InputField pass_inp;
    public Button register;
    public Button ok;
    public Text showtxt;
    public Image msgbox;
    public Button back;
    void Start()
    {
        pass_inp.inputType = InputField.InputType.Password;
        register.onClick.AddListener(delegate () { StartCoroutine(Register_Called()); });
        back.onClick.AddListener(delegate () { back_onclick(); }); 
        msgbox.gameObject.SetActive(false);
    }
    IEnumerator Register_Called()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", user_inp.text);
        form.AddField("password", pass_inp.text);
        WWW www = new WWW("http://147.234.32.72/server/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Messagebox_show("User Created Successfully!", 1);

        }
        else
        {
            Messagebox_show("User creation failed. Error # " + www.text, 2);
        }
    }
    public void VerifyInputs()
    {
        register.interactable = (user_inp.text.Length >= 4 && pass_inp.text.Length >= 8);
    }
    void Messagebox_show(string showstr, int state)
    {
        msgbox.gameObject.SetActive(true);
        showtxt.text = showstr;
        if (state == 1)
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
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }
    void back_onclick()
    {
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }
}
