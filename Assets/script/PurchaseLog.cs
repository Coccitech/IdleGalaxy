using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCoins;
    public GameObject mercure;
    public static float autoCoins;
    void Start()
    {
        mercure.gameObject.SetActive(false);
        autoCoins = 0;
    }
    public void StartAutoCoins()
    {
        if(Score.ClickCount <= Mercure.mercureValue)
        {
            
        }
        else
        {
            AutoCoins.SetActive(true);
            Score.ClickCount -= Mercure.mercureValue;
            Mercure.mercureValue *= 2;
            autoCoins++;
            rotationquaternion.degreesPerSecond = rotationquaternion.degreesPerSecond * 1.75f;
            mercure.gameObject.SetActive(true);
        }
        
    }
}
