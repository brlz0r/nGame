using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SaveLoad : MonoBehaviour
{
    private string filePath;
    private string jsonData;
    private string loadData;

    [Serializable] private class Save
    {
        public int Money;
    }
    Save sv = new Save();
    private void OnApplicationQuit()
    {
        sv.Money = GetComponent<Player>().Money;
        filePath = Path.Combine(Application.persistentDataPath, "Save.json");
        jsonData = JsonUtility.ToJson(sv);
        File.WriteAllText(filePath, jsonData);
    }

    private void OnApplicationPause(bool pause)
    {
        sv.Money = GetComponent<Player>().Money;
        filePath = Path.Combine(Application.persistentDataPath, "Save.json");
        jsonData = JsonUtility.ToJson(sv);
        File.WriteAllText(filePath, jsonData);
    }

    private void Awake()
    {
        filePath = Path.Combine(Application.persistentDataPath, "Save.json");
        loadData = File.ReadAllText(filePath);
        sv = JsonUtility.FromJson<Save>(loadData);
        GetComponent<Player>().Money = sv.Money;
    }
}
