using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float ClickCount;
    public GameObject clickDisplay;
    public GameObject clickDisplay2;
    public float internalClick;
    public float coinss;
    public float coinss1;
    public float coinss2;
    public float total;
    void Start()
    {
        ClickCount = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        coinss = PurchaseLog.autoCoins;
        coinss1 = PurchaseLogVenus.autoCoins;
        coinss2 = PurchaseLogTerre.autoCoins;
        total = coinss + coinss1+coinss2;
        internalClick = ClickCount;
        clickDisplay.GetComponent<Text>().text = "Coins: " + internalClick;
        clickDisplay2.GetComponent<Text>().text = "Coins/s: \n" + total;

        if (Input.GetMouseButtonDown(0)||Input.touchCount > 0)
        {
            Debug.Log("click");
            ClickCount++;

        }
    }
    
}
