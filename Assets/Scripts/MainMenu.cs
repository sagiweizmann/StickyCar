using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static DBManager;
public class MainMenu : MonoBehaviour
{
    public Button play;
    public Button highscore;
    public Button shop;
    public Button settings;
    public Text txt_coins;
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(delegate () { play_onclick(); });
        highscore.onClick.AddListener(delegate () { highscore_onclick(); });
        shop.onClick.AddListener(delegate () { shop_onclick(); });
        settings.onClick.AddListener(delegate () { settings_onclick(); });
        txt_coins.text = coins.ToString();
    }
    void settings_onclick()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);

    }
    void play_onclick()
    {
        SceneManager.LoadScene("LevelSelect", LoadSceneMode.Single);
    }
    void highscore_onclick()
    {
        SceneManager.LoadScene("HighScore", LoadSceneMode.Single);

    }
    void shop_onclick()
    {
        SceneManager.LoadScene("Shop", LoadSceneMode.Single);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
