﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {
    public GameObject wordPrefab;
    public Transform worldCanvas;
public WordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);


        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, worldCanvas);

        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
        
          
        
    }
    
}
