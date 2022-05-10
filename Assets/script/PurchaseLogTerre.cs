using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLogTerre : MonoBehaviour
{
    public GameObject AutoCoins;
    public GameObject terre;
    public static float autoCoins;
    void Start()
    {
        terre.gameObject.SetActive(false);
        autoCoins = 0;
    }
    public void StartAutoCoins()
    {
        if (Score.ClickCount <= Terre.terreValue)
        {

        }
        else
        {
            AutoCoins.SetActive(true);
            Score.ClickCount -= Terre.terreValue;
            Terre.terreValue *= 2;
            autoCoins = autoCoins + 100;
            rotaQuaTerre.degreesPerSecond1 = rotaQuaTerre.degreesPerSecond1 * 4f;
            terre.gameObject.SetActive(true);
        }

    }
}
