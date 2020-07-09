using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public Button register;
    public Button login;

    // Start is called before the first frame update
    void Start()
    {
        register.onClick.AddListener(delegate () { register_called(); });
        login.onClick.AddListener(delegate () { login_called(); });

    }
    void login_called()
    {
        SceneManager.LoadScene("Login", LoadSceneMode.Single);
    }
    void register_called()
    {
        SceneManager.LoadScene("Register", LoadSceneMode.Single);
    }
}
