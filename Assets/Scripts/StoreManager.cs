using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static DBManager;
public class StoreManager : MonoBehaviour
{
    public static StoreManager storeManager;
    public Text txt_coins;
    public Image msgbox;
    public Text txt_msgbox;
    public Button btn_buy;
    public Button btn_item1;
    public Button btn_item2;
    public Button btn_item3;
    public Button btn_item4;
    public Button btn_item5;
    public Button btn_item6;
    public Button btn_item7;
    public Button btn_item8;
    public Button btn_itemequip;
    public Button btn_back;
    public Button btn_backmsg;
    public Image loading_box;
    public int buy_itemid, buy_amount;
    // Start is called before the first frame update
    void Start()
    {
        storeManager = this;
        loading_box.gameObject.SetActive(false);
        msgbox.gameObject.SetActive(false);
        btn_item1.onClick.AddListener(delegate () { btn_item1_onclick(); });
        btn_item2.onClick.AddListener(delegate () { btn_item2_onclick(); });
        btn_item3.onClick.AddListener(delegate () { btn_item3_onclick(); });
        btn_item4.onClick.AddListener(delegate () { btn_item4_onclick(); });
        btn_item5.onClick.AddListener(delegate () { btn_item5_onclick(); });
        btn_item6.onClick.AddListener(delegate () { btn_item6_onclick(); });
        btn_item7.onClick.AddListener(delegate () { btn_item7_onclick(); });
        btn_item8.onClick.AddListener(delegate () { btn_item8_onclick(); });
        btn_back.onClick.AddListener(delegate () { back_onclick(); });
        btn_backmsg.onClick.AddListener(delegate () { backmsg_onclick(); });
        btn_buy.onClick.AddListener(delegate () { btn_buy_onclick(); });

        UpdateUI();
        StartCoroutine(get_item_ids());

    }
    //Function To check which items exists.
    bool check_items(int itemid)
    {
        if (currentitems.Contains(itemid.ToString()))
        {
            return true;
        }
        else return false;
    }
    IEnumerator get_item_ids()
    {
        WWWForm form = new WWWForm();
        form.AddField("id", DBManager.id);
        WWW www = new WWW("http://147.234.32.72/server/getitems.php", form);
        yield return www;
        DBManager.currentitems = www.text;
    }
    IEnumerator coins_update()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("coins", coins);

        WWW www = new WWW("http://147.234.32.72/server/updatecoins.php", form);
        yield return www;

    }
    IEnumerator equip_update(int itemid)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("itemid", itemid);

        WWW www = new WWW("http://147.234.32.72/server/equipitem.php", form);
        yield return www;

    }
    IEnumerator insert_item(int itemid)
    {
        WWWForm form = new WWWForm();
        form.AddField("userid", id);
        form.AddField("itemid", itemid);

        WWW www = new WWW("http://147.234.32.72/server/insertitem.php", form);
        yield return www;

    }
    IEnumerator wait_msg(string showstr, int amount, int itemid)
    {
        loading_box.gameObject.SetActive(true);
        UpdateUI();
        yield return new WaitForSeconds(3);
        loading_box.gameObject.SetActive(false);
        messagebox_show(showstr, amount, itemid);

    }
    void messagebox_show(string showstr, int amount,int itemid)
    {
        msgbox.gameObject.SetActive(true);
        txt_msgbox.text =  showstr;
        btn_itemequip.onClick.AddListener(delegate () { btn_itemequip_onclick(itemid); });
        buy_itemid = itemid;
        buy_amount = amount;
        if(check_items(itemid))
        {
            btn_buy.interactable = false;
            btn_itemequip.interactable = true;
        }
        else
        {
            btn_buy.interactable = true;
            btn_itemequip.interactable = false;
        }
        if(coins<amount)
        {
            btn_buy.interactable = false;
        }
    }
    void btn_item1_onclick()
    {
        StartCoroutine(wait_msg("PIRATE SKIN COSTS 50 COINS\n", 50,1));
    }
    void btn_item2_onclick()
    {
        StartCoroutine(wait_msg("BATMAN SKIN COSTS 100 COINS", 100, 2));
    }
    void btn_item3_onclick()
    {
        StartCoroutine(wait_msg("CAMO SKIN COSTS 150 COINS", 150, 3));
    }
    void btn_item4_onclick()
    {
        StartCoroutine(wait_msg("SPIDERMAN SKIN COSTS 200 COINS", 200, 4));
    }
    void btn_item5_onclick()
    {
        StartCoroutine(wait_msg("CYBER SKIN COSTS 250 COINS", 250, 5));
    }
    void btn_item6_onclick()
    {
        StartCoroutine(wait_msg("RAIN-BOW SKIN COSTS 300 COINS", 300, 6));
    }
    void btn_item7_onclick()
    {
        StartCoroutine(wait_msg("GALAXY SKIN COSTS 350 COINS", 350, 7));
    }
    void btn_item8_onclick()
    {
        StartCoroutine(wait_msg("SNAKE SKIN COSTS 400 COINS", 400, 8));
    }
    void btn_itemequip_onclick(int itemid)
    {
        currentskin = itemid;
        StartCoroutine(equip_update(itemid));
        msgbox.gameObject.SetActive(false);
    }
    void btn_buy_onclick()
    {
        if (RequestCoins(buy_amount))
        {
            ReduceCoins(buy_amount);
            StartCoroutine(insert_item(buy_itemid));
        }
        UpdateUI();
        msgbox.gameObject.SetActive(false);
    }
    public void ReduceCoins(int amount)
    {
        coins -= amount;
        StartCoroutine(coins_update());
    }
    public bool RequestCoins(int amount)
    {
        if(amount<=coins)
        {
            return true;
        }
        return false;
    }
    // Update is called once per frame
    void back_onclick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    
    void backmsg_onclick()
    {
        msgbox.gameObject.SetActive(false);
    }
    void UpdateUI()
    {
        txt_coins.text = coins.ToString();
        StartCoroutine(get_item_ids());
        //Debug.Log(coins);
    }
    void Update()
    {
        
    }
}   
