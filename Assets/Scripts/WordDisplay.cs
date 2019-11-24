using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordDisplay : MonoBehaviour
{
   
    public Text text;
    public static float fallSpeed;
    public void SetWord(string word)
    {
        text.text = word;

    }

    
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        if (ChangeTextColor.count == 1)
        {

            text.color = Color.blue;
        }
        if (ChangeTextColor.count == 2)
        {

            text.color = Color.red;
        }
        if (ChangeTextColor.count == 3)
        {

            text.color = Color.black;
        }

    }
    public void RemoveWord()
    {
        Destroy(gameObject);
        Score.wordsTyped++;
    }
    public void RemoveWord2()
    {
        if (gameObject.transform.position.y <= -220)
        {
            Destroy(gameObject);

        }
    }

    private void Update()
    {

        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
       
    }
    
}
