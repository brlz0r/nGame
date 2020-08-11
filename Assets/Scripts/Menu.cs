using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _OpenMenu;
    [SerializeField] private GameObject _Menu; 
    public void OpenMenu()
    {
        _Menu.SetActive(true);
    }
}
