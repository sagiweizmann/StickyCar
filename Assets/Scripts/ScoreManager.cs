using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static DBManager;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
        text.text = "X" + coins.ToString();
        audio = gameObject.AddComponent<AudioSource>();
      
    }

    public void ChangeScore(int coinValue)
    {
        coins += coinValue;
        text.text = "X" + coins.ToString();
        audio.PlayOneShot((AudioClip)Resources.Load("coin"));
    }
   
}
