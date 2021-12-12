using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName =  "ShopMenu", menuName = "Scriptable Objects/New Shop Item", order = 1)]
public class ShopItemSO : ScriptableObject
{
    public string title;
    public string description;
    public float basecost;
    public float AktyvusDidinmas;
    public float pasyvusDidinimas;

    public bool arAktyvus;
    public bool arPasyvus;

}
