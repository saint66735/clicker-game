using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ijungimas : MonoBehaviour
{

    public GameObject Parduotuve;
    public GameObject Coins;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Parduotuve.activeInHierarchy == true)
            {
                Parduotuve.SetActive(false);
            }
            else
                Parduotuve.SetActive(true);



            if (Coins.activeInHierarchy == true)
            {
                Coins.SetActive(false);
            }
            else
                Coins.SetActive(true);



            if (Text.activeInHierarchy == true)
            {
                Text.SetActive(false);
            }
            else
                Text.SetActive(true);
        }
    }



}
