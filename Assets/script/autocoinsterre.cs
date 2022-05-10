using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autocoinsterre : MonoBehaviour
{
    public bool creatingCoins = false;
    public float coinIncrease;
    public float internalIncrease;


    void Start()
    {


    }


    void Update()
    {

        internalIncrease = PurchaseLogTerre.autoCoins;
        coinIncrease = internalIncrease;
        if (creatingCoins == false)
        {
            creatingCoins = true;
            StartCoroutine(CreateTheCoin());
        }


    }
    IEnumerator CreateTheCoin()
    {
        Score.ClickCount += internalIncrease;
        yield return new WaitForSeconds(1);
        creatingCoins = false;
    }
}
