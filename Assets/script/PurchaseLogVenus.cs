using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLogVenus : MonoBehaviour
{
    public GameObject AutoCoins;
    public GameObject venus;
    public static float autoCoins;
    void Start()
    {
        venus.gameObject.SetActive(false);
        autoCoins = 0;
    }
    public void StartAutoCoins()
    {
        if (Score.ClickCount <= Venus.venusValue)
        {

        }
        else
        {
            AutoCoins.SetActive(true);
            Score.ClickCount -= Venus.venusValue;
            Venus.venusValue *= 2;
            autoCoins=autoCoins+10;
            rotaquaMars.degreesPerSecond1 = rotaquaMars.degreesPerSecond1 * 4f;
            venus.gameObject.SetActive(true);
        }

    }
}
