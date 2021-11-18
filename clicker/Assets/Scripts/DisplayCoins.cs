using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoins : MonoBehaviour
{
    public Text yenCoinsText;
    public ClickLogic A;

    // Start is called before the first frame update
    void Start()
    {
        A = FindObjectOfType<ClickLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        yenCoinsText.text = A.yenCoins.ToString();
    }
}
