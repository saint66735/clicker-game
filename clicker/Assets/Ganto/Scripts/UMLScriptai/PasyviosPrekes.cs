using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasyviosPrekes : MonoBehaviour
{


    public int KiekPasyvausPaspaudimo;

    public int PasyvausKofas;

    private void Start()
    {
        KiekPasyvausPaspaudimo = 0;
    }

    public void Add()
    {

        KiekPasyvausPaspaudimo++;

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

