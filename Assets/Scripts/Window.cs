using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject[] Win;
    public float time = 10.0f;
    public float hWind = 14;
    public int _random;
    void Start()
    {
        _random = (int)UnityEngine.Random.Range(0.0f, hWind - 1);
        _Win(false);
    }

    void Update()
    {
        _Win(_random);
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            Win[_random].SetActive(false);
            _random = (int)UnityEngine.Random.Range(0.0f, hWind - 1);
            time = 10.0f;
        }
    }
    public void _Win(bool set)
    {
        if (set == true)
        {
            for (int i = 0; i < hWind; i++)
            {
                Win[i].SetActive(true);
            }
        } else
        {
            for (int i = 0; i < hWind; i++)
            {
                Win[i].SetActive(false);
            }
        } 
    }
    public void _Win(int rand)
    {
        Win[rand].SetActive(true);
    }
} 