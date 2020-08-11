using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private Button _OpenMain;
    [SerializeField] private GameObject _Menu;
    public void OpenMenu()
    {
        _Menu.SetActive(false);
    }
}
