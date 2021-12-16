using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCoins : MonoBehaviour
{
    public Text yenCoinsText;
    public ClickLogic A;
    public double roundUp;
    public double roundUp2;
    public Text clickText;
    // Start is called before the first frame update
    void Start()
    {
        A = FindObjectOfType<ClickLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        roundUp = System.Math.Round(GameManager2.instance.score, 1);
        yenCoinsText.text = roundUp.ToString();

        roundUp2 = System.Math.Round(A.increase * A.Active_Kof, 1);
        clickText.text = roundUp2.ToString();
    }
}
