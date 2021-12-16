using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktyviosPrekes : MonoBehaviour
{
    public static AktyviosPrekes instance = null;

    public int KiekAktyvausPaspaudimo;
    public int VisosAktyviosPrekes;

    void Awake()
    {

        KiekAktyvausPaspaudimo = 0;
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

        KiekAktyvausPaspaudimo++;
        VisosAktyviosPrekes++;

    }

    public bool Check()
    {

        if (KiekAktyvausPaspaudimo == 2)
        {
            return true;
        }
        else return false;

    }


    public void Reset()
    {

        KiekAktyvausPaspaudimo = 0;

    }
}
