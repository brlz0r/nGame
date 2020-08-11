using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private GameObject EllipseSecondHand;
    [SerializeField] private GameObject EllipseMinuteHand;
    [SerializeField] private GameObject EllipseHourHand;

    private float _Time = 360.0f;
    

    private void Update()
    {
        _Time -= Time.deltaTime;
        EllipseSecondHand.transform.rotation = Quaternion.Euler(0.0f, 0.0f, _Time * 12);
        EllipseMinuteHand.transform.rotation = Quaternion.Euler(0.0f, 0.0f, _Time * 6);
        EllipseHourHand.transform.rotation = Quaternion.Euler(0.0f, 0.0f, _Time * 3);
        if (_Time <= 0)
        {
            _Time = 360.0f;
        }
    }
}
