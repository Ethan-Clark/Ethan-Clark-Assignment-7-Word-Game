using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderManager : MonoBehaviour {

    public Slider speedSlider;
    public static float sliderValue = 1f;
    public Text sliderText;
    
    void Update()
    {
        sliderValue = speedSlider.value;
        sliderText.text = speedSlider.value.ToString();
        WordDisplay.fallSpeed = sliderValue;
        PlayerPrefs.SetFloat("SliderValue", sliderValue);
    }
}
