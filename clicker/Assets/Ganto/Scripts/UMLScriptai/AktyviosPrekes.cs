using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktyviosPrekes : MonoBehaviour
{


    public int KiekAktyvausPaspaudimo;
    //public int KiekPasyvausPaspaudimo;

    // public int PasyvausKofas;
    public int AktyvausKofas;

    private void Start()
    {
        KiekAktyvausPaspaudimo = 0;
        //KiekPasyvausPaspaudimo = 0;
    }

    public void Add()
    {

        KiekAktyvausPaspaudimo++;

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
