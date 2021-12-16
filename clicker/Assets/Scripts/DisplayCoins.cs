using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCoins : MonoBehaviour
{
    public Text yenCoinsText;
    public ClickLogic A;

    public passiveIncome B;
    public double roundUp;
    public double roundUp2;
    public double roundUp3;
    public Text clickText;
    public Text secondText;
    // Start is called before the first frame update
    void Start()
    {
        A = FindObjectOfType<ClickLogic>();
        B = FindObjectOfType<passiveIncome>();
    }

    // Update is called once per frame
    void Update()
    {
        roundUp = System.Math.Round(GameManager2.instance.score, 2);
        yenCoinsText.text = roundUp.ToString();

        roundUp2 = System.Math.Round(A.increase * A.Active_Kof, 2);
        clickText.text = roundUp2.ToString();

        roundUp3 = System.Math.Round(B.passiveIncrease * B.Passive_Kof, 2);
        secondText.text = roundUp3.ToString();
    }
}
