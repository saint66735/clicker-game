using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ijungimas : MonoBehaviour
{

    public GameObject Shop_Canvas;
    public GameObject Shop_Event;

    public GameObject UI_Canvas;
    public GameObject UI_Event;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Shop_Canvas.activeInHierarchy == true)
            {
                Shop_Canvas.SetActive(false);
            }
            else
                Shop_Canvas.SetActive(true);



            if (Shop_Event.activeInHierarchy == true)
            {
                Shop_Event.SetActive(false);
            }
            else
                Shop_Event.SetActive(true);


            //--------------------------------------------//


            if (UI_Canvas.activeInHierarchy == true)
            {
                UI_Canvas.SetActive(false);
            }
            else
                UI_Canvas.SetActive(true);



            if (UI_Event.activeInHierarchy == true)
            {
                UI_Event.SetActive(false);
            }
            else
                UI_Event.SetActive(true);
        }
    }



}
