using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance = null;

    public float score = 0.0f;

    public int building1Count;
    public int building2Count;

    public int amountOfUpgrades;
    GameData data;

    public ShopManager Shop;



    void Start()
    {
        Shop = FindObjectOfType<ShopManager>();


        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            if (FindObjectOfType<MenuManager>().loaded)
                NotifyLoad();
        }

        if (FindObjectOfType<MenuManager>().loaded == false) 
        {
            Shop.KainuResetas();
        }


    }
    public GameData UpdateState()
    {
        return new GameData(score, 0, building1Count, building2Count);
    }
    void NotifyLoad()
    {
        Save.instance.ApplyLoad();
        CurrentState.instance.CaptureState();
    }

}
