using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveScore : MonoBehaviour {

    public Text showScore;
    private int wordsTypedScore;
    void Start ()
    {
        wordsTypedScore = Score.wordsTyped;

        showScore.text = "Words Typed: " + wordsTypedScore;
    }
	
	
		

}
