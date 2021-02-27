using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public string LastScore; 

    void Start()
    {
        
        PlayerPrefs.GetInt("CurrentScore");
    }


    void Update()
    {
        
    }
}
