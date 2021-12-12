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

    //Kintamieji mano
    public int KiekAktyvausPaspaudimo;
    public int KiekPasyvausPaspaudimo;
    public GameManager2 Logika;
    public ShopLaikmena_SingleTon ParduotuvesKintamieji;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanelsSO[i].SetActive(true);
        }
        //coinUI.text = "Coins: " + coins.ToString();
        
        CheckPurchesable();


        //valdau kintamuosius cia
        Logika = FindObjectOfType<GameManager2>();
        ParduotuvesKintamieji = FindObjectOfType<ShopLaikmena_SingleTon>();
        KainuResetas();

        LoadPanels();
    }

    // Update is called once per frame
    void Update()
    {
        coins = Logika.score;
        CheckPurchesable();
    }

    public void AddCoins() //Prideda Pinigus
    {
        //coins++;
        //coinUI.text = "Coins: " + coins.ToString();


        Logika.score++;
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


    public void PurchaseItems(int btnNo)
    {
        if (coins >= shopItemsSO[btnNo].basecost)
        {
            Logika.score = Logika.score - shopItemsSO[btnNo].basecost;

            //Patikrina kokio tipo preke tai yra
            //Skaiciuoja kiek kartu buvo nupirkta preke
            if (shopItemsSO[btnNo].arAktyvus)
            {
                ParduotuvesKintamieji.KiekAktyvausPaspaudimo++;
            }
            if (shopItemsSO[btnNo].arPasyvus)
            {
                ParduotuvesKintamieji.KiekPasyvausPaspaudimo++;
            }
            //Skaiciuoja kiek kartu buvo nupirkta preke
            //ParduotuvesKintamieji.KiekAktyvausPaspaudimo++;
            //ParduotuvesKintamieji.KiekPasyvausPaspaudimo++;
            //Patikrina ar reikia didinti prekes kaina
            AktyvausPadidinimas(btnNo);
            PasyvausPadidinimas(btnNo);
            LoadPanels();
        }

    }


        public void LoadPanels()
        {

        for (int i = 0; i < shopItemsSO.Length; i++)
            {
                shopPanels[i].titleTxt.text = shopItemsSO[i].title;
                shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
                shopPanels[i].costTxt.text = "Coins: " + shopItemsSO[i].basecost.ToString();
            }

        }


    public void AktyvausPadidinimas(int btnNo)
    {
        if (ParduotuvesKintamieji.KiekAktyvausPaspaudimo == 2)
        {
            shopItemsSO[btnNo].basecost = shopItemsSO[btnNo].basecost * 2;
            ParduotuvesKintamieji.KiekAktyvausPaspaudimo = 0;
        }
    }

    public void PasyvausPadidinimas(int btnNo)
    {
        if (ParduotuvesKintamieji.KiekPasyvausPaspaudimo == 2)
        {
            shopItemsSO[btnNo].basecost = shopItemsSO[btnNo].basecost * 2;
            ParduotuvesKintamieji.KiekPasyvausPaspaudimo = 0;
        }
    }


    public void KainuResetas()
    {
        shopItemsSO[0].basecost = 1;
        shopItemsSO[1].basecost = 1;

    }
}

