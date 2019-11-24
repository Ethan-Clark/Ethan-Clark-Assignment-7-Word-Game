using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showspeed : MonoBehaviour {
    public Text showSpeed;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        showSpeed.text = "Speed: " + PlayerPrefs.GetFloat("SliderValue");

    }
    }
