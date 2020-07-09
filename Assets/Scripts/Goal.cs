using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public Image congrats;
    public GameObject goal;
    public Button btn_nextlevel;
    public Button btn_pause;
    public Button btn_mainmenu;
	void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("Player"))
		{
            //Debug.Log("GAME WON! :D");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 0f;
            congrats.gameObject.SetActive(true);
            btn_mainmenu.onClick.AddListener(delegate () { mainmenu_onclick(); });
            btn_nextlevel.onClick.AddListener(delegate () { nextlevel_onclick(); });
            goal.SetActive(false);
            btn_pause.interactable = false;
            

        }
    }

    void mainmenu_onclick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    void nextlevel_onclick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
