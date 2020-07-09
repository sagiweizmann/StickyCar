using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Settings : MonoBehaviour
{
    public Button btn_back;
    public Button btn_music;
    public Sprite OnSprite;
    public Sprite OffSprite;
    // Start is called before the first frame update
    void Start()
    {
        btn_back.onClick.AddListener(delegate () { back_onclick(); });
        btn_music.onClick.AddListener(delegate () { music_onclick(); });
        if (PlayerPrefs.GetInt("music") == 0)
        {
            btn_music.image.sprite = OffSprite;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            btn_music.image.sprite = OnSprite;
        }
    }
    void back_onclick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    void music_onclick()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            btn_music.image.sprite =OnSprite ;
            AudioListener.pause = true;
            PlayerPrefs.SetInt("music", 1);
            PlayerPrefs.Save();
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            btn_music.image.sprite = OffSprite;
            AudioListener.pause = false;
            PlayerPrefs.SetInt("music", 0);
            PlayerPrefs.Save();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
