using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donate : MonoBehaviour
{
    [SerializeField] private GameObject WindowDonate;
    [SerializeField] private Text NameText;
    [SerializeField] private Text MoneyText;
    
    public int minMoney;
    public int maxMoney;
    public int Money;
    private int SizeRandomName; 

    public float RandomDonateTime;
    private float TimeDonationWindow; 

    public bool DonateActive = false;
    public bool isDonate = false;
    public bool isStreaming = true;
    
    private string TextDonation;
    private string DonatePlayerName;
    
    private readonly char[] Alphabet = new char[] 
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
        'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
        'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
        'y', 'z'
    };
    private void Start()
    {
        isStreaming = true;
        TimeDonationWindow = 6.0f;
        TextDonation = "Thanks";
        minMoney = 1;
        maxMoney = 15;
        RandomDonateTime = UnityEngineRandom(5.0f, 15.0f);
    }
    private void Update()
    {
        if (isStreaming)
        {
            RandomDonateTime -= Time.deltaTime;
            if (RandomDonateTime <= 0)
            {
                _Donate();
                RandomDonateTime = UnityEngineRandom(15.0f, 35.0f);
            }
            if (DonateActive == true)
            {
                TimeDonationWindow -= Time.deltaTime;
                if (TimeDonationWindow <= 0)
                {
                    TimeDonationWindow = 6.0f;
                    WindowDonate.SetActive(false);
                    DonateActive = false;
                }
            }
        }
    }
    private void _Donate()
    {
        DonateActive = true;
        WindowDonate.SetActive(true);
        DonatePlayerName = null;
        SizeRandomName = (int)UnityEngineRandom(3,9);
        for (int i = 0; i < SizeRandomName; i++)
        {
            DonatePlayerName += Alphabet[(int)UnityEngineRandom(0, 25)];
        }
        Money = (int)UnityEngineRandom(minMoney, maxMoney); 
        NameText.text = DonatePlayerName + " " + "Donated";
        MoneyText.text = "$" + Money;
        isDonate = true;
    }
    public float UnityEngineRandom(float min, float max)
    {
        float _CurrentRandom = UnityEngine.Random.Range(min, max);
        return _CurrentRandom;
    }
}
