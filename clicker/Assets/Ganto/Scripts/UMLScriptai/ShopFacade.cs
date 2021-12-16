using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFacade : MonoBehaviour //Klase skirta persiusti duomenis i reikiamas klases.
{
    double a;

    public AktyviosPrekes AktyvusKintamieji;
    public PasyviosPrekes PasyvusKintamieji;
    public Kofu_Decorator Kofai;

    //Pakeicia kofus pirkimo
    public ClickLogic ActiveLogic;
    public passiveIncome PassiveLogic;

    // Start is called before the first frame update
    void Start()
    {
        AktyvusKintamieji = FindObjectOfType<AktyviosPrekes>();
        PasyvusKintamieji = FindObjectOfType<PasyviosPrekes>();
        Kofai = FindObjectOfType<Kofu_Decorator>();
        ActiveLogic = FindObjectOfType<ClickLogic>();
        PassiveLogic = FindObjectOfType<passiveIncome>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AktyvusAdd() { AktyvusKintamieji.Add(); }
    public bool AktyvusCheck() { return AktyvusKintamieji.Check(); }
    public void AktyvusReset() { AktyvusKintamieji.Reset(); }

    public void PasyvusAdd() { PasyvusKintamieji.Add(); }
    public bool PasyvusCheck() { return PasyvusKintamieji.Check(); }
    public void PasyvusReset() { PasyvusKintamieji.Reset(); }

    public float Item1(float a) { return Kofai.Item1(a); }
    public void Active_Kof() { ActiveLogic.Active_Kof = 0.2f * AktyvusKintamieji.TakeAll(); }


    public float Item2(float a) { return Kofai.Item2(a); }
    public void Passive_Kof() { PassiveLogic.Passive_Kof = 0.5f * PasyvusKintamieji.TakeAll(); }



}
