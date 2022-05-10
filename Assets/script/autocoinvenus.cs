using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autocoinvenus : MonoBehaviour
{
    public bool creatingCoins = false;
    public float coinIncrease;
    public float internalIncrease;


    void Start()
    {


    }


    void Update()
    {

        internalIncrease = PurchaseLogVenus.autoCoins;
        coinIncrease = internalIncrease;
        if (creatingCoins == false)
        {
            creatingCoins = true;
            StartCoroutine(CreateTheCoin2());
        }


    }
    IEnumerator CreateTheCoin2()
    {
        Score.ClickCount += internalIncrease;
        yield return new WaitForSeconds(1);
        creatingCoins = false;
    }
}

