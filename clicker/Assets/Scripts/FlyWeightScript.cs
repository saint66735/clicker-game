using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Random = UnityEngine.Random;

//Flyweight design pattern main class


public class Grass
{
    public Vector3 location;
    public static Vector3 size = new Vector3(2.0f, 2.0f, 2.0f);
    public static Color color = Color.green;
    public Vector3 rotation;
}
public class FlyWeightScript : MonoBehaviour
{
    //The list that stores all aliens
    List<GameObject> allGrass = new List<GameObject>();

    public Grass grass = new Grass();
    public GameObject grassObject;
    List<Vector3> grassRotation;
    Vector3 grassSize;
    List<Vector3> grassPosition;


    void Start()
    {

        //Create all aliens
        for (int i = 0; i < 1000; i++)
        {
            grass.location = GeneratePosition();
            grass.rotation = GenerateRotation();
            Instantiate(grassObject, grass.location, Quaternion.Euler(grass.rotation));
        }
    }

    private Vector3 GeneratePosition()
    {
        Vector3 random = new Vector3(Random.Range(-1.0f, 1.0f), 0.364f, Random.Range(-9.0f, -7.0f)); 
        return random;

    }

    private Vector3 GenerateRotation()
    {
        Vector3 random = new Vector3(0, Random.Range(0f, 360.0f), -90);
        return random;
    }

    private List<Vector3> GetRotation()
    {
        throw new NotImplementedException();
    }




}
