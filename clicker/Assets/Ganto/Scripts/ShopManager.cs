using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsSO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanelsSO[i].SetActive(true);
        }
        coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();
        //CheckPurchasable();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins() //Prideda Pinigus
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        //CheckPurchasable();
    }
    public void CheckPurchasable() //Prideda Pinigus
    {


    }


        public void LoadPanels() //Prideda Pinigus
    {

        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = "Coins: " + shopItemsSO[i].basecost.ToString();
        }
    }
}

