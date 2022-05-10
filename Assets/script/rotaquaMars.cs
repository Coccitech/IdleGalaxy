using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaquaMars : MonoBehaviour
{
    public GameObject objectToOrbit;
    public float angle;
    public float radius =1.75f;
    public static float degreesPerSecond1;
    void Start()
    {
        degreesPerSecond1 = 1;
    }
    void Update()
    {
        angle += degreesPerSecond1 * Time.deltaTime;
        if (angle > 360)
        {
            angle -= 360;
        }
        Vector3 orbit = Vector3.forward * radius;
        orbit = Quaternion.Euler(0, angle, 0) * orbit;
        transform.position = objectToOrbit.transform.position + orbit;
    }
}
