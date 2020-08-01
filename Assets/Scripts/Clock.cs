using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
   
    public GameObject clock;
    public float time = 360.0f;
    void Update()
    {
        time -= Time.deltaTime * 8;
        clock.transform.rotation = Quaternion.Euler(0.0f, 0.0f, time);
        if (time <= 0)
        {
            time = 360.0f;
        }
    }
}
