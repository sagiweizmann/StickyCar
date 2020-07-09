using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public Button pause_btn;
    public Image pause_menu;
    public Button btn_exit;
    public Button btn_resume;
    public Button btn_restart;
    void Start()
    {
        pause_btn.onClick.AddListener(delegate () { pause_btn_onclick(); });
        btn_resume.onClick.AddListener(delegate () { btn_resume_onclick(); });
        btn_restart.onClick.AddListener(delegate () { btn_restart_onclick(); });
        btn_exit.onClick.AddListener(delegate () { btn_exit_onclick(); });
        pause_menu.gameObject.SetActive(false);
    }
    void pause_btn_onclick()
    {
        pause_menu.gameObject.SetActive(true);
        Time.timeScale = 0f;

    }
    void btn_resume_onclick()
    {
        pause_menu.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    void btn_restart_onclick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void btn_exit_onclick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
