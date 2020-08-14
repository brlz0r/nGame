using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donate : MonoBehaviour
{
    [SerializeField] private GameObject WindDonate;
    [SerializeField] private Text Name;
    [SerializeField] private Text Money;
    [SerializeField] private Text yourMoney;
    public int minMoney;
    public int maxMoney;
    public int inthMoney;
    public float RandomDonateTime;
    public bool DonateActive = false;
    public bool isDonate = false;
    public bool isStreaming = true;
    public string strhMoney;
    private string TextDonation;
    private int SizeRandomName;
    private float TimeDonationWind;
    private string DonatePlayerName; 
    private readonly string[] Alphabet = new string[] 
    {
        "a", "b", "c", "d", "e", "f", "g", "h",
        "i", "j", "k", "l", "m", "n", "o", "p", 
        "q", "r", "s", "t", "u", "v", "w", "x", 
        "y", "z"
    };
    private void Start()
    {
        isStreaming = true;
        TimeDonationWind = 6.0f;
        TextDonation = "Thanks";
        minMoney = 1;
        maxMoney = 1234;
        RandomDonateTime = UnityEngineRandom(5.0f, 15.0f);
    }
    private void Update()
    {
        if (isStreaming)
        {
            RandomDonateTime -= Time.deltaTime;
            if (RandomDonateTime <= 0)
            {
                _DonateSubs();
                RandomDonateTime = UnityEngineRandom(15.0f, 35.0f);
            }
            if (DonateActive == true)
            {
                TimeDonationWind -= Time.deltaTime;
                if (TimeDonationWind <= 0)
                {
                    TimeDonationWind = 6.0f;
                    WindDonate.SetActive(false);
                    DonateActive = false;
                }
            }
        }
    }
    private void _DonateSubs()
    {
        DonateActive = true;
        WindDonate.SetActive(true);
        DonatePlayerName = "";
        SizeRandomName = (int)UnityEngineRandom(3,9);
        for (int i = 0; i < SizeRandomName; i++)
        {
            DonatePlayerName += Alphabet[(int)UnityEngineRandom(0, 25)];
        }
        inthMoney = UnityEngine.Random.Range(minMoney, maxMoney);
        strhMoney = "$" + inthMoney;
        Name.text = DonatePlayerName + " " + "Donated";
        Money.text = strhMoney;
        isDonate = true;
    }
public float UnityEngineRandom(float min, float max)
    {
        float _CurrentRandom = UnityEngine.Random.Range(min, max);
        return _CurrentRandom;
    }
}

