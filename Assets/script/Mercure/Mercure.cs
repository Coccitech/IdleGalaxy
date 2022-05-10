using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mercure : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCoin;
    public static float mercureValue=20;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCoin = Score.ClickCount;
        fakeText.GetComponent<Text>().text = "value : \n" + mercureValue;
        realText.GetComponent<Text>().text = "value : \n" + mercureValue;
        if (currentCoin>=mercureValue)
        {

            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}
