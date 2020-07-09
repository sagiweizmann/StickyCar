using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HighScore : MonoBehaviour
{
    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;
    public Text name5;
    public Text name6;
    public Text name7;
    public Text name8;
    public Text name9;
    public Text name10;
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    public Text score5;
    public Text score6;
    public Text score7;
    public Text score8;
    public Text score9;
    public Text score10;
    public Button btn_back;

    // Start is called before the first frame update
    void Start()
    {
        btn_back.onClick.AddListener(delegate () { back_onclick(); });
        StartCoroutine(Display_score());
    }
    IEnumerator Display_score()
    {
        string[] s=new string[20];
        WWWForm form = new WWWForm();
        WWW www = new WWW("http://147.234.32.72/server/display.php", form);
        yield return www;
       // Debug.Log(www.text);
        s=www.text.Split(';');
        name1.text = "1." + s[0].ToUpper();
        score1.text = s[1];
        name2.text = "2." + s[2].ToUpper();
        score2.text = s[3];
        name3.text = "3." + s[4].ToUpper();
        score3.text = s[5];
        name4.text = "4." + s[6].ToUpper();
        score4.text = s[7];
        name5.text = "5." + s[8].ToUpper();
        score5.text = s[9];
        name6.text = "6." + s[10].ToUpper();
        score6.text = s[11];
        name7.text = "7." + s[12].ToUpper();
        score7.text = s[13];
        name8.text = "8." + s[14].ToUpper();
        score8.text = s[15];
        name9.text = "9." + s[16].ToUpper();
        score9.text = s[17];
        name10.text = "10." + s[18].ToUpper();
        score10.text = s[19];
    }
    void back_onclick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
