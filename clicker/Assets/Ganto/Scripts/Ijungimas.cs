using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ijungimas : MonoBehaviour
{

    public GameObject parduotuve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (parduotuve.activeInHierarchy == true)
            {
                parduotuve.SetActive(false);
            }
            else
                parduotuve.SetActive(true);
        }
    }



    public void whenButtonClicked() 
    {
        if (parduotuve.activeInHierarchy == true)
        {
            parduotuve.SetActive(false);
        }
        else
            parduotuve.SetActive(true);

    }
}
