using System.Collections;
//using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShopManager : MonoBehaviour
{
    public float coins;
    public TMP_Text coinUI;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsSO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;

    //Kintamieji mano
    public GameManager2 Logika;
    //public AktyviosPrekes ParduotuvesKintamieji;
    public ShopFacade Facade;
    //Instanc geliu atsiradimui
    public createFlora Flora;

    public float roundUp;




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
        Facade = FindObjectOfType<ShopFacade>();
        Flora = FindObjectOfType<createFlora>();

        KainuResetas();

        LoadPanels();
    }

    // Update is called once per frame
    void Update()
    {
        coins = Logika.score;
        CheckPurchesable();
        roundUp = (float)System.Math.Round(Logika.score, 1);
        coinUI.text = roundUp.ToString();
    }

    public void AddCoins() //Prideda Pinigus
    {
        Logika.score = Logika.score + 500;
        CheckPurchesable();
    }

    public void CheckPurchesable()
    {

        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            if (coins >= shopItemsSO[i].basecost)
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
                Facade.AktyvusAdd();
            }
            if (shopItemsSO[btnNo].arPasyvus)
            {
                Facade.PasyvusAdd();
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
        if (Facade.AktyvusCheck())
        {
            //shopItemsSO[btnNo].basecost = shopItemsSO[btnNo].basecost * 2;
            shopItemsSO[btnNo].basecost = (float)Math.Round((Facade.Item1(shopItemsSO[btnNo].basecost)), 2);
            Facade.AktyvusReset();
            Flora.AddActiveItemFlora(1);
            //Facade.Active_Kof();
        }
        Facade.Active_Kof();
    }

    public void PasyvausPadidinimas(int btnNo)
    {
        if (Facade.PasyvusCheck())
        {
            //shopItemsSO[btnNo].basecost = shopItemsSO[btnNo].basecost * 2;
            shopItemsSO[btnNo].basecost = (float)Math.Round((Facade.Item2(shopItemsSO[btnNo].basecost)), 2);
            Facade.PasyvusReset();
            Flora.AddPassiveItemFlora(1);
        }
        Facade.Passive_Kof();
    }


    public void KainuResetas()
    {
        shopItemsSO[0].basecost = 3.73f;
        shopItemsSO[1].basecost = 60;

    }
}