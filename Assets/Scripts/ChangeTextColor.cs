using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeTextColor : MonoBehaviour
{


    public Dropdown myDropdown;
    public static int count;
    void Start()
    {
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);



    }
    void Update()
    {

        switch (myDropdown.value)
        {
            
            case 1:
               count = 1;
                break;
            case 2:
               count = 2;
               break;
            case 3:
                count = 3;
                break;


        }

    }
}
