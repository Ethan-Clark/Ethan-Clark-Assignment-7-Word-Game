using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public static int wordsTyped = 0;
    public static int wordsMissed = 0;
    public Text WordsTyped;
    public Text WordsMissed;
    void Start()
    {
        wordsTyped = 0;
       wordsMissed = 0;
    }
    void Update () {
        PlayerPrefs.SetInt("Words typed", wordsTyped);
        WordsTyped.text = wordsTyped.ToString();
       PlayerPrefs.SetInt("Words missed", wordsMissed);
       WordsMissed.text = wordsMissed.ToString();

    }
}
