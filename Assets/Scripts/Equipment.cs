using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Equipment : MonoBehaviour
{
    List<_Equipment._WebCam> webCams = new List<_Equipment._WebCam>() 
    {
       new _Equipment._WebCam("WebCam1", "100", "4", "1080", "1920", "1080", "30", false, false),
       new _Equipment._WebCam("WebCam2", "200", "5", "1080", "1920", "1080", "60", false, false),
       new _Equipment._WebCam("WebCam3", "300", "6", "1080", "1920", "1080", "60", false, false)
    };

    public static class _Equipment
    {
        public class _WebCam
        {
            public string Name; // Example WebCamName
            public string Price; // Example 111
            public string DonatePrice; // Exaple 4
            public string hResolution; // Example 1080
            public string wResolution; // Example 1920
            public string hDefinition; // Example 1080
            public string Fps; // Example 30
            public bool Purchased; // Example true
            public bool Selected; // Example true

            public _WebCam(string name, string price, string donateprice, string hResolution, string wResolution, 
                string hDefinition, string fps, bool purchased, bool selected)
            {
                Name = name;
                Price = price;
                DonatePrice = donateprice;
                this.hResolution = hResolution;
                this.wResolution = wResolution;
                this.hDefinition = hDefinition;
                Fps = fps;
                Purchased = purchased;
                Selected = selected;
            }
        }
        public class Microphone
        {
            public string Name; // Example MicrophoneName
            public string Price; // Example 111
            public string minFrequency; // Example  50 (Hz)
            public string maxFrequency; //  160000 (Hz)
            public bool Purchased; // Example true
            public bool Selected; // Example true
        }
        public class PC
        {
           
        }
    }
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
