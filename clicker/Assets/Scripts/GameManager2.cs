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
    public int building3Count;

    public int amountOfUpgrades;

    GameData data;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);           
        }    
        instance = this;
        NotifyLoad();
    }
    public GameData UpdateState()
    {
        return new GameData(score, 0, building1Count, building2Count, building3Count);
    }
    void NotifyLoad()
    {
        FindObjectOfType<Save>().ApplyLoad(instance);
    }

}
