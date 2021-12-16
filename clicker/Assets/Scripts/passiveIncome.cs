using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passiveIncome : MonoBehaviour
{
    public float passiveIncrease = 0.1f;
    public ClickLogic A;

    private float timer = 0f;
    public float delayAmount;

    public float Passive_Kof = 1;

    // Start is called before the first frame update
    void Start()
    {
        A = FindObjectOfType<ClickLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            timer = 0f;
            GameManager2.instance.score += passiveIncrease * Passive_Kof;
        }
    }
}
