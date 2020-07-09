using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public Button back;
    public Button btn_level1;
    public Button btn_level2;
    public Button btn_level3;
    public Button btn_level4;
    public Button btn_level5;
    public Button btn_level6;
    public Button btn_level7;
    public Button btn_level8;
    public Button btn_level9;
    public Button btn_level10;
    public Button btn_level11;
    public Button btn_level12;
    public Button btn_level13;
    public Button btn_level14;
    public Button btn_level15;
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(delegate () { back_onclick(); });
        btn_level1.onClick.AddListener(delegate () { btn_level1_onclick(); });
        btn_level2.onClick.AddListener(delegate () { btn_level2_onclick(); });
        btn_level3.onClick.AddListener(delegate () { btn_level3_onclick(); });
        btn_level4.onClick.AddListener(delegate () { btn_level4_onclick(); });
        btn_level5.onClick.AddListener(delegate () { btn_level5_onclick(); });
        btn_level6.onClick.AddListener(delegate () { btn_level6_onclick(); });
        btn_level7.onClick.AddListener(delegate () { btn_level7_onclick(); });
        btn_level8.onClick.AddListener(delegate () { btn_level8_onclick(); });
        btn_level9.onClick.AddListener(delegate () { btn_level9_onclick(); });
        btn_level10.onClick.AddListener(delegate () { btn_level10_onclick(); });
        btn_level11.onClick.AddListener(delegate () { btn_level11_onclick(); });
        btn_level12.onClick.AddListener(delegate () { btn_level12_onclick(); });
        btn_level13.onClick.AddListener(delegate () { btn_level13_onclick(); });
        btn_level14.onClick.AddListener(delegate () { btn_level14_onclick(); });
        btn_level15.onClick.AddListener(delegate () { btn_level15_onclick(); });
    }

    void back_onclick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    void btn_level1_onclick()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);

    }
    void btn_level2_onclick()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);

    }
    void btn_level3_onclick()
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);

    }
    void btn_level4_onclick()
    {
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);

    }
    void btn_level5_onclick()
    {
        SceneManager.LoadScene("Level5", LoadSceneMode.Single);

    }
    void btn_level6_onclick()
    {
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);

    }
    void btn_level7_onclick()
    {
        SceneManager.LoadScene("Level7", LoadSceneMode.Single);

    }
    void btn_level8_onclick()
    {
        SceneManager.LoadScene("Level8", LoadSceneMode.Single);

    }
    void btn_level9_onclick()
    {
        SceneManager.LoadScene("Level9", LoadSceneMode.Single);

    }
    void btn_level10_onclick()
    {
        SceneManager.LoadScene("Level10", LoadSceneMode.Single);

    }
    void btn_level11_onclick()
    {
        SceneManager.LoadScene("Level11", LoadSceneMode.Single);

    }
    void btn_level12_onclick()
    {
        SceneManager.LoadScene("Level12", LoadSceneMode.Single);

    }
    void btn_level13_onclick()
    {
        SceneManager.LoadScene("Level13", LoadSceneMode.Single);

    }
    void btn_level14_onclick()
    {
        SceneManager.LoadScene("Level14", LoadSceneMode.Single);

    }
    void btn_level15_onclick()
    {
        SceneManager.LoadScene("Level15", LoadSceneMode.Single);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
