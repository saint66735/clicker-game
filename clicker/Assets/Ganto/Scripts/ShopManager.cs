using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public float coins;
    //public TMP_Text coinUI;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsSO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;

    //Kintamieji
    public ClickLogic Logika;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanelsSO[i].SetActive(true);
        }
        //coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();

        CheckPurchesable();




        //valdau kintamuosius cia
        Logika = FindObjectOfType<ClickLogic>();


    }

    // Update is called once per frame
    void Update()
    {
        coins = Logika.yenCoins;
        CheckPurchesable();
    }

    public void AddCoins() //Prideda Pinigus
    {
        //coins++;
        //coinUI.text = "Coins: " + coins.ToString();


        Logika.yenCoins++;
        CheckPurchesable();
    }

    public void CheckPurchesable() 
    {

        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            if(coins >= shopItemsSO[i].basecost) 
            {
                myPurchaseBtns[i].interactable = true; 
            }
            else
                myPurchaseBtns[i].interactable = false;

        }
    }


    public void PurchaseItems(int btnNo) //Prideda Pinigus
    {
        if (coins >= shopItemsSO[btnNo].basecost)
        {
            Logika.yenCoins = Logika.yenCoins - shopItemsSO[btnNo].basecost;
            //CheckPurchesable();
        }

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

