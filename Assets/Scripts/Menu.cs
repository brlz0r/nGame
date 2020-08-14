using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _OpenMenu;
    [SerializeField] private GameObject _Menu;

    private void Start()
    {
        if (Advertisement.isSupported)
        {
           Advertisement.Initialize("3763785", false);
        }
    }         
    public void OpenMenu()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
        _Menu.SetActive(true);
    }
}
