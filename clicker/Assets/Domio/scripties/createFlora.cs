using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class createFlora : MonoBehaviour
{
    public GameObject yellowFlora;
    public GameObject redFlora;
    public GameObject greenFlora;

    public Grass grass = new Grass();
    public GameObject grassObject;



    public class Grass
    {
        public Vector3 location;
        public static Vector3 size = new Vector3(0.092721f, 0.092721f, 0.092721f);
        public Vector3 rotation;
    }

    public void AddActiveItemFlora(int active)
    {
        for (int i = 0; i < active; i++)
        {
            grass.location = GeneratePosition();
            grass.rotation = GenerateRotation();
            Instantiate(yellowFlora, grass.location, Quaternion.Euler(grass.rotation));
        }
        
    }

    public void AddPassiveItemFlora(int passive)
    {

        for (int i = 0; i < passive; i++)
        {
            grass.location = GeneratePosition();
            grass.rotation = GenerateRotation();
            Instantiate(yellowFlora, grass.location, Quaternion.Euler(grass.rotation));
        }
    }

   


    private Vector3 GeneratePosition()
    {
        Vector3 random = new Vector3(Random.Range(-1.0f, 1.0f), 0.227f, Random.Range(-9.0f, -7.0f));
        return random;

    }

    private Vector3 GenerateRotation()
    {
        Vector3 random = new Vector3(0, Random.Range(0f, 360.0f), 0);
        return random;
    }





}


