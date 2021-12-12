using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance = null;

    public float score = 0.0f;

    public int amountOfStructures;

    public int amountOfUpgrades;


    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
           
        }    
        instance = this;
    }


}
