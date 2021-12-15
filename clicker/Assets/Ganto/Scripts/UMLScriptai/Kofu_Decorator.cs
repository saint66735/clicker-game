using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kofu_Decorator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float Item1(float a)
    {
        a = a * (float)1.07;

        return a;
    }


    public float Item2(float a)
    {
        a = a * (float)1.15;

        return a;
    }



}
