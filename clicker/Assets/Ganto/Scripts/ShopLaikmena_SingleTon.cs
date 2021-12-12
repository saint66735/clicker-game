using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLaikmena_SingleTon : MonoBehaviour
{


    public int KiekAktyvausPaspaudimo;
    public int KiekPasyvausPaspaudimo;

    public int PasyvausKofas;
    public int AktyvausKofas;

    private void Start()
    {
        KiekAktyvausPaspaudimo = 0;
        KiekPasyvausPaspaudimo = 0;
    }
}
