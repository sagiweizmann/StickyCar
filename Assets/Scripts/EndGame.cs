using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static DBManager;
public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("Collidable"))
		{
            StartCoroutine(Coins_update());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        }
       


    }
    IEnumerator Coins_update()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("coins", coins);

        WWW www = new WWW("http://147.234.32.72/server/updatecoins.php", form);
        yield return www;
      
    }
}
