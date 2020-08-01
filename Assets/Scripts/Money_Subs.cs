using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Subs : MonoBehaviour
{
    public GameObject WindDonate;
    public Text Name;
    public Text Money;
    public int minMoney;
    public int maxMoney;
    public int SizeRandomName;
    public int inthMoney;
    public float TimeDonationWind;
    public float _RandomDonateTime;
    public float _NewDonateTime;
    public bool DonateActive = false;
    public string TextDonation;
    public string strhMoney;
    public string DonatePlayerName; 
    public string[] Alphabet = new string[] 
    {
        "a", "b", "c", "d", "e", "f", "g", "h",
        "i", "j", "k", "l", "m", "n", "o", "p", 
        "q", "r", "s", "t", "u", "v", "w", "x", 
        "y", "z"
    };
    void Start()
    {
        TimeDonationWind = 6.0f;
        TextDonation = "Thanks";
        minMoney = 1;
        maxMoney = 1234;
        _RandomDonateTime = UnityEngine.Random.Range(5.0f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        _RandomDonateTime -= Time.deltaTime; 
        if (_RandomDonateTime <= 0)
        {
            _DonateSubs();
            _RandomDonateTime = UnityEngine.Random.Range(15.0f, 35.0f);
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
    public void _DonateSubs()
    {
        DonateActive = true;
        WindDonate.SetActive(true);
        DonatePlayerName = "";
        SizeRandomName = (int)UnityEngine.Random.Range((float)3, (float)9);
        for (int i = 0; i < SizeRandomName; i++)
        {
            DonatePlayerName += Alphabet[(int)UnityEngine.Random.Range((float)0, (float)25)];
        }
        inthMoney = UnityEngine.Random.Range(minMoney, maxMoney);
        strhMoney = "$" + inthMoney;
        Name.text = DonatePlayerName + " " + "Donated";
        Money.text = strhMoney;
    }
}

