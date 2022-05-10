using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Terre : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCoin;
    public static float terreValue = 2000;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentCoin = Score.ClickCount;
        fakeText.GetComponent<Text>().text = "value : \n" + terreValue;
        realText.GetComponent<Text>().text = "value : \n" + terreValue;
        if (currentCoin >= terreValue)
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
