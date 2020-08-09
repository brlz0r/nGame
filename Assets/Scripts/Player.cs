using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int Money;
    public int Followers;
    public int Viewers;
    public int Level;
    public int DonateValue;

    [SerializeField] private Animation Hand;
    [SerializeField] private Animation Coffee;
    [SerializeField] private Animation PlayerA;

    [SerializeField] private Text text;

    private float time = 6.0f;
    private void Start()
    {
        time = GetComponent<Donate>().UnityEngineRandom(5.0f, 21.0f);
    }

    private void Update()
    {
        text.text = Money.ToString();
        if (GetComponent<Donate>().isDonate)
        {
            Money += GetComponent<Donate>().inthMoney;
            GetComponent<Donate>().isDonate = false;
        }
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            Hand.Play();
            Coffee.Play();
            PlayerA.Play();
            time = GetComponent<Donate>().UnityEngineRandom(5.0f, 21.0f);
        }
    }
}
