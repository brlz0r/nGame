using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animation anim;
    public float time = 6.0f;
    void Start()
    {
        time = GetComponent<Money_Subs>().UnityEngineRandom(5.0f, 21.0f);
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            anim.Play();
            time = GetComponent<Money_Subs>().UnityEngineRandom(5.0f, 21.0f);
        }
    }
}
