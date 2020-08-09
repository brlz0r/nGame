using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField] private Animation Cloud1;
    [SerializeField] private Animation Cloud2;
    [SerializeField] private Animation Cloud3;
    private void Update()
    {
        Cloud1.Play();
        Cloud2.Play();
        Cloud3.Play();
    }
}
