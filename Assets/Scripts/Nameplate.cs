using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Nameplate : MonoBehaviour
{
    [SerializeField] private Text ViewersText;
    [SerializeField] private Text MoneyText;
    [SerializeField] private Text FollowersText;

    private int Viewers;
    private int Money;
    private int Followers;
    private void Update()
    {
        Viewers = GetComponent<Player>().Viewers;
        Money = GetComponent<Player>().Money;
        Followers = GetComponent<Player>().Followers;
        ViewersText.text = Viewers.ToString();
        MoneyText.text = Money.ToString();
        FollowersText.text = Followers.ToString();
    }
}
