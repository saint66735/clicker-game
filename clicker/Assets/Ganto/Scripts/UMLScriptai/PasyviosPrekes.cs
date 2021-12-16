using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasyviosPrekes : MonoBehaviour
{

    public static PasyviosPrekes instance = null;

    public int KiekPasyvausPaspaudimo;

    public int VisosPasyviosPrekes;

    //private void Start()
    //{
    //    KiekPasyvausPaspaudimo = 0;
    //}

    void Awake()
    {

        KiekPasyvausPaspaudimo = 0;
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

    }

    public void Add()
    {

        KiekPasyvausPaspaudimo++;
        VisosPasyviosPrekes++;

    }

    public bool Check()
    {

        if (KiekPasyvausPaspaudimo == 2)
        {
            return true;
        }
        else return false;

    }


    public void Reset()
    {

        KiekPasyvausPaspaudimo = 0;

    }
}

