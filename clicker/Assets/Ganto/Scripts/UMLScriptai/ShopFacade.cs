using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFacade : MonoBehaviour //Klase skirta persiusti duomenis i reikiamas klases.
{


    public AktyviosPrekes AktyvusKintamieji;
    public PasyviosPrekes PasyvusKintamieji;

    // Start is called before the first frame update
    void Start()
    {
        AktyvusKintamieji = FindObjectOfType<AktyviosPrekes>();
        PasyvusKintamieji = FindObjectOfType<PasyviosPrekes>();
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

}
